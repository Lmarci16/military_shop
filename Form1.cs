using System.Windows.Forms;

namespace military_shop
{
    public partial class Form1 : Form
    {
        class Termekek
        {
            public string cikkszam, termeknev;
            public int keszlet, ar;
        }
        class Rendeles
        {
            public string rendcikkszam, nev, cim, rendtermnev;
            public int darab;
        }
        List<Termekek> termekek = new List<Termekek>();
        List<Rendeles> rendeles = new List<Rendeles>();
        public static int hiany=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader be = new StreamReader("termekek.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] sor = be.ReadLine().Split(";");
                Termekek seged = new Termekek();
                seged.termeknev = sor[1];
                seged.cikkszam = sor[2];
                seged.ar = int.Parse(sor[4]);
                seged.keszlet = int.Parse(sor[5]);
                termekek.Add(seged);
            }
            be.Close();

            for (int i = 0; i < termekek.Count; i++)
            {
                ListViewItem elem = new ListViewItem(termekek[i].termeknev);
                elem.SubItems.Add(termekek[i].cikkszam);
                elem.SubItems.Add(termekek[i].ar.ToString());
                elem.SubItems.Add(termekek[i].keszlet.ToString());
                listView1.Items.Add(elem);

            }

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader rend = new StreamReader("megrendeles.txt");
            richTextBox1.Text = rend.ReadLine();
            richTextBox1.Text += "\n" + rend.ReadLine();
            while (!rend.EndOfStream)
            {
                string[] sor = rend.ReadLine().Split(';');
                Rendeles seged = new Rendeles();
                seged.rendcikkszam = sor[0];
                seged.rendtermnev = sor[1];
                seged.darab = Convert.ToInt32(sor[2]);
                rendeles.Add(seged);
            }
            for (int i = 0; i < rendeles.Count; i++)
            {
                richTextBox1.Text += "\n" + rendeles[i].rendcikkszam + "\n";
                richTextBox1.Text += rendeles[i].rendtermnev + "\n";
                richTextBox1.Text += rendeles[i].darab + "\n";
            }
            int osszeg = 0;
            for (int i = 0; i < rendeles.Count; i++)
            {
                for (int j = 0; j < termekek.Count; j++)
                {
                    if (rendeles[i].rendcikkszam == termekek[j].cikkszam && termekek[j].keszlet < rendeles[i].darab)
                    {
                        hiany = rendeles[i].darab - termekek[j].keszlet;
                        MessageBox.Show("Nincs elég darab, hiányzik: " + hiany + " " + rendeles[i].rendtermnev);

                    }
                    if (rendeles[i].rendcikkszam == termekek[j].cikkszam)
                    {
                        osszeg += rendeles[i].darab * termekek[j].ar;
                    }


                }
            }
            richTextBox1.Text += "Fizetendõ: " + osszeg;
            foreach (var r in rendeles)
            {
                var jatek = termekek.FirstOrDefault(x => x.cikkszam == r.rendcikkszam);

                if (jatek != null)
                {
                    jatek.keszlet -= r.darab;

                    if (jatek.keszlet < 0)
                        jatek.keszlet = 0;
                }
            }
            listView1.Items.Clear();

            foreach (var j in termekek)
            {
                ListViewItem elem = new ListViewItem(j.termeknev);
                elem.SubItems.Add(j.cikkszam);
                elem.SubItems.Add(j.ar.ToString());
                elem.SubItems.Add(j.keszlet.ToString());
                listView1.Items.Add(elem);
            }
            List<string> elojegyezheto = new List<string>();
            for (int i = 0; i < termekek.Count; i++)
            {
                if (termekek[i].keszlet == 0)
                {
                    elojegyezheto.Add(termekek[i].termeknev);
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("hiany.txt");
            for (int i = 0; i < rendeles.Count; i++)
            {
                for (int j = 0; j < termekek.Count; j++)
                {
                    if (rendeles[i].rendcikkszam == termekek[j].cikkszam && termekek[j].keszlet < rendeles[i].darab)
                    {
                        
                        f.WriteLine(termekek[j].cikkszam+termekek[j].termeknev+ termekek[j].ar+" "+hiany.ToString());
                        f.Close();
                    }
                    


                }
            }
        }
    }
}