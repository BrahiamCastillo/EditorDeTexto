using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cuadroresultado.Text=="")
            {
                return;
            } else if(MessageBox.Show("¿Desea guardar los cambios?","Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                save.FilterIndex = 1;
                save.FileName = "Text_1";
                if(save.ShowDialog()==DialogResult.OK)
                {
                    cuadroresultado.SaveFile(save.FileName);
                    cuadroresultado.Text = "";
                }
                else
                {
                    cuadroresultado.Text = "";
                }
            }
            else
            {
                cuadroresultado.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            open.FilterIndex = 1;
            open.FileName = "";
            open.Title = "Abrir";
            if(open.ShowDialog()==DialogResult.OK)
            {
                cuadroresultado.LoadFile(open.FileName);
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            guardar.FilterIndex = 1;
            guardar.FileName = "Text_1";
            guardar.Title = "Guardar";
            if(guardar.ShowDialog()==DialogResult.OK)
            {
                cuadroresultado.SaveFile(guardar.FileName);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cuadroresultado.Text == "")
            {
                Application.Exit();
            }
            else if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                save.FilterIndex = 1;
                save.FileName = "Text_1";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    cuadroresultado.SaveFile(save.FileName);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
