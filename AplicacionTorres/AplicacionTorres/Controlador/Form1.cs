using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AplicacionTorres
{
    public partial class Form1 : Form
    {
        ListBox torreorigen;
        Stack pilaorigen = new Stack();
        Hanoi hanoi = new Hanoi();
        int movimientos;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int discos = Convert.ToInt16(cmbDiscos.SelectedItem);
            lista1.Items.Clear();
            lista1.Items.Clear();
            lista1.Items.Clear();
            hanoi.clear();
            for (int i = discos; i>0 ; i--)
            {
                lista1.Items.Insert(0, i);
                hanoi.torre1.Push(i);
            }
            movimientos = 0;
            lbMov.Text = string.Format("Movimientos {0}", movimientos);
        }

        private void findeljuego()
        {
            movimientos++;
            lbMov.Text = string.Format("Movimientos: {0}", movimientos);
            if(hanoi.torre3.Count == Convert.ToInt32(cmbDiscos.Text))
                MessageBox.Show("Ganaste","Torres de Hanoi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lista1_DragDrop(object sender, DragEventArgs e)
        {
            if(Vista.intercambiar(lista1, torreorigen, hanoi.torre1, pilaorigen))
            findeljuego();
        }

        private void hacerdragdown(ListBox lista, Stack pila)
        {
            try
            {
                torreorigen = lista;
                pilaorigen = pila;
                lista.DoDragDrop(lista.SelectedItem, DragDropEffects.Move);
            }
            catch { }
        }

        private void lista2_DragDrop(object sender, DragEventArgs e)
        {
            if(Vista.intercambiar(lista2, torreorigen, hanoi.torre2, pilaorigen));
            findeljuego();
        }

        private void lista3_DragDrop(object sender, DragEventArgs e)
        {
            if(Vista.intercambiar(lista3, torreorigen, hanoi.torre3, pilaorigen));
            findeljuego();
        }

        private void lista1_MouseDown(object sender, MouseEventArgs e)
        {
            hacerdragdown(lista1, hanoi.torre1);
        }

        private void lista2_MouseDown(object sender, MouseEventArgs e)
        {
            hacerdragdown(lista2, hanoi.torre2);
        }

        private void lista1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lista3_MouseDown(object sender, MouseEventArgs e)
        {
            hacerdragdown(lista3, hanoi.torre3);
        }


    }
}
