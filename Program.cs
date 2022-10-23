using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace WindowsFormsApp1

{

    public partial class Form1 : Form

    {



        public Form1()

        {

            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)

        {

            int a = 1;

            int b = 1;

            // var z = ArttırVeTopla(ref a, ref b);

            var c = ArttırVeToplanoref(a, b);

        }



        public int ArttırVeTopla(ref int x, ref int y)

        {

            x += 1;

            y += y;

            return (x + y);

        }



        public int ArttırVeToplanoref(int x, int y)

        {

            x += 1;

            y += y;

            return (x + y);

        }

    }

}