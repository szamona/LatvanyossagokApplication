using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=;");
            conn.Open();
            adatbazisLetrehoz();
            varosokTablaLetrehozas();
            latvanyosagokTablaLetrehozas();
            VarosListazas();
            LatvanyossagListazas();
            ModositGroupBox();
            LModositGroupBox();
        }


        void latvanyosagokTablaLetrehozas()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS `latvanyossagok` (
                                  `id` int(11) NOT NULL AUTO_INCREMENT,
                                  `nev` varchar(128) COLLATE utf8_hungarian_ci NOT NULL,
                                  `leiras` varchar(128) COLLATE utf8_hungarian_ci NOT NULL,
                                  `ar` int(11) NOT NULL DEFAULT '0',
                                  `varos_id` int(11) NOT NULL,
                                  PRIMARY KEY (`id`),
                                  KEY `varos_id` (`varos_id`),
                                FOREIGN KEY(varos_id) REFERENCES varosok (id) ON DELETE CASCADE ON UPDATE CASCADE
                                ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;";
            cmd.ExecuteNonQuery();
        }
        void ModositGroupBox()
        {
             if (listBoxVarosok.SelectedIndex>=0)
            {
                groupBoxModositas.Enabled = true;
            }
            else
            {
                groupBoxModositas.Enabled = false;
            }
        }
        void LModositGroupBox()
        {
            if (listBoxLatvanyossagok.SelectedIndex>=0)
            {
                groupBoxLatvanyossagModosit.Enabled = true;
            }
            else
            {
                groupBoxLatvanyossagModosit.Enabled = false;
            }
        }
        private void adatbazisLetrehoz()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE DATABASE IF NOT EXISTS `latvanyossagokdb` 
                                DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
                            USE `latvanyossagokdb`;";
            cmd.ExecuteNonQuery();
        }
        void varosokTablaLetrehozas()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS `varosok` (
                                  `id` int(11) NOT NULL AUTO_INCREMENT,
                                  `nev` varchar(128) COLLATE utf8_hungarian_ci NOT NULL,
                                  `lakossag` int(11) NOT NULL,
                                  PRIMARY KEY (`id`),
                                  UNIQUE KEY `nev_indx` (`nev`)
                                ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;";
            cmd.ExecuteNonQuery();
        }

        void VarosListazas()
        {
            listBoxVarosok.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id, nev, lakossag FROM varosok";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    Varos varos = new Varos(id,nev,lakossag);
                    listBoxVarosok.Items.Add(varos);
                }
            }
            ModositGroupBox();
        }
        void LatvanyossagListazas()
        {
            listBoxLatvanyossagok.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id, nev, leiras, ar, varos_id
                                FROM latvanyossagok";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var varos_id= reader.GetInt32("varos_id");
                    Latvanyossag latvanyossag = new Latvanyossag(id, nev,leiras,ar,varos_id);
                    listBoxLatvanyossagok.Items.Add(latvanyossag);
                }
            }
        }

        private void ButtonHozzaad_Click(object sender, EventArgs e)
        {
            if (textBoxVarosok.Text != "" && Char.IsUpper(textBoxVarosok.Text, 0))
            {
                labelVarosnev.ForeColor = Color.Black;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO varosok (nev,lakossag)
                                              VALUES(@nev,@lakossag)";
                cmd.Parameters.AddWithValue("@nev", textBoxVarosok.Text);
                cmd.Parameters.AddWithValue("@lakossag", numericUpDownLakossag.Value);
                cmd.ExecuteNonQuery();
                VarosListazas();
            }
            else if (textBoxVarosok.Text == "")
            {
                MessageBox.Show("Adja meg a város nevét!");
                labelVarosnev.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("A város neve nagybetűvel kell kezdődjön!");
                labelVarosnev.ForeColor = Color.Red;

            }

        }

        private void ButtonTorol_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE  
                                FROM varosok
                                WHERE id = @id";
            Varos varos = (Varos)listBoxVarosok.SelectedItem;
            cmd.Parameters.AddWithValue("@id", varos.Id);
            cmd.ExecuteNonQuery();
            VarosListazas();

        }

        private void ButtonLHozzaad_Click(object sender, EventArgs e)
        {
            if (textBoxLatvanyossagNev.Text != "" && Char.IsUpper(textBoxLatvanyossagNev.Text, 0))
            {
                labelLatvanyossagNev.ForeColor = Color.Black;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO latvanyossagok (nev, leiras, ar, varos_id)
                                              VALUES(@nev, @leiras, @ar, @varos_id)";
                cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossagNev.Text);
                cmd.Parameters.AddWithValue("@leiras", textBoxLatvanyossagLeiras.Text);
                cmd.Parameters.AddWithValue("@ar", numericUpDownLatvanyossagAr.Value);
                Varos varos = (Varos)listBoxVarosok.SelectedItem;
                cmd.Parameters.AddWithValue("@varos_id", varos.Id);

                cmd.ExecuteNonQuery();
                LatvanyossagListazas();
            }
            else if (textBoxLatvanyossagNev.Text == "")
            {
                MessageBox.Show("Adja meg a látványosság nevét!");
                labelLatvanyossagNev.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("A látványosság neve nagybetűvel kell kezdődjön!");
                labelLatvanyossagNev.ForeColor = Color.Red;

            }


        }

        private void ListBoxVarosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModositGroupBox();
            if (listBoxVarosok.SelectedIndex>=0)
            {
                Varos varos = (Varos)listBoxVarosok.SelectedItem;
                textBoxVarosNevModosit.Text = varos.Nev;
                numericUpDownVarosLakossagModosit.Value = varos.Lakossag;

            }

        }

        private void ButtonVarosModosit_Click(object sender, EventArgs e)
        {

            if (textBoxVarosNevModosit.Text != "" && Char.IsUpper(textBoxVarosNevModosit.Text, 0))
            {
                labelUjvarosnev.ForeColor = Color.Black;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE varosok
                                    SET  
                                        nev = @nev,
                                        lakossag = @lakossag
                                    WHERE id=@id";
                cmd.Parameters.AddWithValue("@nev", textBoxVarosNevModosit.Text);
                cmd.Parameters.AddWithValue("@lakossag", numericUpDownVarosLakossagModosit.Value);
                Varos varos = (Varos)listBoxVarosok.SelectedItem;
                cmd.Parameters.AddWithValue("@id", varos.Id);
                cmd.ExecuteNonQuery();
                VarosListazas();
                LatvanyossagListazas();
            }
            else if (textBoxVarosNevModosit.Text == "")
            {
                MessageBox.Show("Adja meg a város nevét!");
                labelUjvarosnev.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("A város neve nagybetűvel kell kezdődjön!");
                labelUjvarosnev.ForeColor = Color.Red;

            }

        }

        private void ButtonLTorles_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE  
                                FROM latvanyossagok
                                WHERE id = @id";
            Latvanyossag latvanyossag = (Latvanyossag)listBoxLatvanyossagok.SelectedItem;
            cmd.Parameters.AddWithValue("@id", latvanyossag.Id);
            cmd.ExecuteNonQuery();
            LatvanyossagListazas();
            
        }

        private void ListBoxLatvanyossagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            LModositGroupBox();
            if (listBoxLatvanyossagok.SelectedIndex >= 0)
            {
                Latvanyossag latvanyossag = (Latvanyossag)listBoxLatvanyossagok.SelectedItem;
                textBoxLatvanyossagUjNEv.Text = latvanyossag.Nev;
                textBoxLatvanyossagUJleiras.Text = latvanyossag.Leiras;
                numericUpDownLatvanyossagUjAr.Value = latvanyossag.Ar;

            }
        }

        private void ButtonLModosit_Click(object sender, EventArgs e)
        {
            if (textBoxLatvanyossagUjNEv.Text != "" && Char.IsUpper(textBoxLatvanyossagUjNEv.Text, 0))
            {
                labelUjlatvanyossagNev.ForeColor = Color.Black;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE latvanyossagok
                                SET  
                                    nev = @nev,
                                    leiras = @leiras,
                                    ar = @ar
                                WHERE id=@id";
                cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossagUjNEv.Text);
                cmd.Parameters.AddWithValue("@leiras", textBoxLatvanyossagUJleiras.Text);
                cmd.Parameters.AddWithValue("@ar", numericUpDownLatvanyossagUjAr.Value);
                Latvanyossag latvanyossag = (Latvanyossag)listBoxLatvanyossagok.SelectedItem;
                cmd.Parameters.AddWithValue("@id", latvanyossag.Id);
                cmd.ExecuteNonQuery();
                LatvanyossagListazas();
            }
            else if (textBoxLatvanyossagUjNEv.Text == "")
            {
                MessageBox.Show("Adja meg a látványosság nevét!");
                labelUjlatvanyossagNev.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("A látványosság neve nagybetűvel kell kezdődjön!");
                labelUjlatvanyossagNev.ForeColor = Color.Red;

            }

        }
    }
}
