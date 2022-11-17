namespace LLenadoDeDiccionarios
{
    public partial class LLenado_De_Diccionarios : Form
    {
        String T;
        String Valor;
        String Clave;
        public LLenado_De_Diccionarios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtSave_Click(object sender, EventArgs e)           // Button save
        {
            richTextBox1.Clear();
            richTextBox2.Clear();

            // Primer archivo

            StreamWriter escribir = new StreamWriter("LLenado_Diccionarios1.txt",true);
            try
            {
                escribir.WriteLine(tBT.Text +".Add(" +C1.Text+tBKey.Text +C2.Text+"," +C3.Text+ tBValue.Text +C4.Text + ");");
            }
            catch
            {
                MessageBox.Show("¡Error! ಥ‿ಥ ");
            }
            escribir.Close();


             //Segundo archivo


            StreamWriter escribir2 = new StreamWriter("LLenado_Diccionarios2.txt", true);
            try
            {
                escribir2.WriteLine(tBT.Text + ".Add(" +C1.Text +tBValue.Text +C2.Text +"," +C3.Text + tBKey.Text +C4.Text +");");
            }
            catch
            {
                MessageBox.Show("¡Error! ಥ‿ಥ ");
            }
            escribir2.Close();

            // Lectura archivo 1

            StreamReader leer = new StreamReader("LLenado_Diccionarios1.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("¡Error!    ಥ‿ಥ ");
            }

            leer.Close();

            // Lectura Archivo 2

            StreamReader leer2 = new StreamReader("LLenado_Diccionarios2.txt");
            string linea2;
            try
            {
                linea2 = leer2.ReadLine();
                while (linea2 != null)
                {
                    richTextBox2.AppendText(linea2 + "\n");
                    linea2 = leer2.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("¡Error!    ಥ‿ಥ ");
            }
            leer2.Close();
            tBKey.Clear();
            tBValue.Clear();
        }

        private void BtRun_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();

            // Lectura archivo 1

            StreamReader leer = new StreamReader("LLenado_Diccionarios1.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while(linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("¡Error!    ಥ‿ಥ ");
            }
            leer.Close ();

            // Lectura Archivo 2

            StreamReader leer2 = new StreamReader("LLenado_Diccionarios2.txt");
            string linea2;
            try
            {
                linea2 = leer2.ReadLine();
                while (linea2 != null)
                {
                    richTextBox2.AppendText(linea2 + "\n");
                    linea2 = leer2.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("¡Error!    ಥ‿ಥ ");
            }
            leer2.Close ();
        }

        private void bTLimpiar_Click(object sender, EventArgs e)
        {
            tBKey.Clear();
            tBValue.Clear();
        }

        private void tBKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // Si al presionar una tecla eso es igual a enter se ejectute el codigo
            {
                richTextBox1.Clear();
                richTextBox2.Clear();

                // Primer archivo

                StreamWriter escribir = new StreamWriter("LLenado_Diccionarios1.txt", true);
                try
                {
                    escribir.WriteLine(tBT.Text + ".Add(" + C1.Text + tBKey.Text + C2.Text + "," + C3.Text + tBValue.Text + C4.Text + ");");
                }
                catch
                {
                    MessageBox.Show("¡Error! ಥ‿ಥ ");
                }
                escribir.Close();


                //Segundo archivo


                StreamWriter escribir2 = new StreamWriter("LLenado_Diccionarios2.txt", true);
                try
                {
                    escribir2.WriteLine(tBT.Text + ".Add(" + C1.Text + tBValue.Text + C2.Text + "," + C3.Text + tBKey.Text + C4.Text + ");");
                }
                catch
                {
                    MessageBox.Show("¡Error! ಥ‿ಥ ");
                }
                escribir2.Close();

                // Lectura archivo 1

                StreamReader leer = new StreamReader("LLenado_Diccionarios1.txt");
                string linea;
                try
                {
                    linea = leer.ReadLine();
                    while (linea != null)
                    {
                        richTextBox1.AppendText(linea + "\n");
                        linea = leer.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("¡Error!    ಥ‿ಥ ");
                }

                leer.Close();

                // Lectura Archivo 2

                StreamReader leer2 = new StreamReader("LLenado_Diccionarios2.txt");
                string linea2;
                try
                {
                    linea2 = leer2.ReadLine();
                    while (linea2 != null)
                    {
                        richTextBox2.AppendText(linea2 + "\n");
                        linea2 = leer2.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("¡Error!    ಥ‿ಥ ");
                }
                leer2.Close();
                tBKey.Clear();
                tBValue.Clear();
            }
        }

        private void tBValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // Si al presionar una tecla eso es igual a enter se ejectute el codigo
            {
                richTextBox1.Clear();
                richTextBox2.Clear();

                // Primer archivo

                StreamWriter escribir = new StreamWriter("LLenado_Diccionarios1.txt", true);
                try
                {
                    escribir.WriteLine(tBT.Text + ".Add(" + C1.Text + tBKey.Text + C2.Text + "," + C3.Text + tBValue.Text + C4.Text + ");");
                }
                catch
                {
                    MessageBox.Show("¡Error! ಥ‿ಥ ");
                }
                escribir.Close();


                //Segundo archivo


                StreamWriter escribir2 = new StreamWriter("LLenado_Diccionarios2.txt", true);
                try
                {
                    escribir2.WriteLine(tBT.Text + ".Add(" + C1.Text + tBValue.Text + C2.Text + "," + C3.Text + tBKey.Text + C4.Text + ");");
                }
                catch
                {
                    MessageBox.Show("¡Error! ಥ‿ಥ ");
                }
                escribir2.Close();

                // Lectura archivo 1

                StreamReader leer = new StreamReader("LLenado_Diccionarios1.txt");
                string linea;
                try
                {
                    linea = leer.ReadLine();
                    while (linea != null)
                    {
                        richTextBox1.AppendText(linea + "\n");
                        linea = leer.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("¡Error!    ಥ‿ಥ ");
                }

                leer.Close();

                // Lectura Archivo 2

                StreamReader leer2 = new StreamReader("LLenado_Diccionarios2.txt");
                string linea2;
                try
                {
                    linea2 = leer2.ReadLine();
                    while (linea2 != null)
                    {
                        richTextBox2.AppendText(linea2 + "\n");
                        linea2 = leer2.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("¡Error!    ಥ‿ಥ ");
                }
                leer2.Close();
                tBKey.Clear();
                tBValue.Clear();
            }
        }

        private void tBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // Si al presionar una tecla eso es igual a enter se ejectute el codigo
            {
                richTextBox1.Clear();
                richTextBox2.Clear();

                // Primer archivo

                StreamWriter escribir = new StreamWriter("LLenado_Diccionarios1.txt", true);
                try
                {
                    escribir.WriteLine(tBT.Text + ".Add(" + C1.Text + tBKey.Text + C2.Text + "," + C3.Text + tBValue.Text + C4.Text + ");");
                }
                catch
                {
                    MessageBox.Show("¡Error! ಥ‿ಥ ");
                }
                escribir.Close();


                //Segundo archivo


                StreamWriter escribir2 = new StreamWriter("LLenado_Diccionarios2.txt", true);
                try
                {
                    escribir2.WriteLine(tBT.Text + ".Add(" + C1.Text + tBValue.Text + C2.Text + "," + C3.Text + tBKey.Text + C4.Text + ");");
                }
                catch
                {
                    MessageBox.Show("¡Error! ಥ‿ಥ ");
                }
                escribir2.Close();

                // Lectura archivo 1

                StreamReader leer = new StreamReader("LLenado_Diccionarios1.txt");
                string linea;
                try
                {
                    linea = leer.ReadLine();
                    while (linea != null)
                    {
                        richTextBox1.AppendText(linea + "\n");
                        linea = leer.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("¡Error!    ಥ‿ಥ ");
                }

                leer.Close();

                // Lectura Archivo 2

                StreamReader leer2 = new StreamReader("LLenado_Diccionarios2.txt");
                string linea2;
                try
                {
                    linea2 = leer2.ReadLine();
                    while (linea2 != null)
                    {
                        richTextBox2.AppendText(linea2 + "\n");
                        linea2 = leer2.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("¡Error!    ಥ‿ಥ ");
                }
                leer2.Close();
                tBKey.Clear();
                tBValue.Clear();
            }
        }
    }
}