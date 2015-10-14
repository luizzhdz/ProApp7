using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AplicacionTorres
{
    static class Vista
    {
        public static bool intercambiar(ListBox listaA, ListBox listaB, Stack destino, Stack origen)
        {
            Object item = listaB.SelectedItem;
            if (item.ToString() != origen.Peek().ToString())
            {
                MessageBox.Show("el elemento no se puede mover", "Torres de Hanoi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listaB.ClearSelected();
            }
            else{
                if (destino.Count == 0 || ((int)origen.Peek() < (int)destino.Peek()))
                {
                    listaA.Items.Insert(0, item);
                    listaB.Items.Remove(item);
                    destino.Push(origen.Peek());
                    origen.Pop();
                    return true;
                }
                else
                {
                    MessageBox.Show("Movimiento no valido", "Torres de Hanoi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listaB.ClearSelected();
                }
            }
            return false;
        }
    }
}
