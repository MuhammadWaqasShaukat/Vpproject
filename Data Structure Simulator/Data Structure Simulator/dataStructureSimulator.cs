using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Data_Structure_Simulator
{
    public partial class dataStructureSimulator : Form
    {
        //.................................Node................................................//
        public class node
        {
            public int value;
            public node left;
            public node right;
            public int level;
            public int x_axis;
            public int y_axis;
            public int line_x, line_y;
            public node(int value, int x, int y)
            {
                this.value = value;
                left = null;
                right = null;
                x_axis = x;
                y_axis = y;
            }
        }
        node top = null;
                public int width, height, x_axisShape, y_axisShape,initialX,initialY;
        //.................................................................................//
        public dataStructureSimulator()
        {
            InitializeComponent();
         }

        //...........................radio Buttons.........................................//
       private void radioButtonStack_CheckedChanged(object sender, EventArgs e)
        {
                dataStructureUsed.Text = radioButtonStack.Text.ToString();
                groupBoxInput.Show();
                groupBoxOptionsStack.Show(); 
        }

        private void radioButtonLinkedList_CheckedChanged(object sender, EventArgs e)
        {
                dataStructureUsed.Text = radioButtonLinkedList.Text.ToString();
                groupBoxInput.Show();
                groupBoxOptionsLinkedList.Show();
        }

        private void radioButtonTree_CheckedChanged(object sender, EventArgs e)
        {
                dataStructureUsed.Text = radioButtonTree.Text.ToString();
                groupBoxInput.Show();
                groupBoxOptionsTree.Show();
        }
        //.............................Group Box DataStructures................................//
        private void groupBoxDataStructure_Enter(object sender, EventArgs e)
        {
            if (radioButtonLinkedList.Checked || radioButtonStack.Checked || radioButtonTree.Checked == true)
            {
                radioButtonTree.Checked = radioButtonStack.Checked = radioButtonLinkedList.Checked = false;
            }
            if (radioButtonStack.Checked == true)
                radioButtonStack_CheckedChanged(sender, e);
            else if(radioButtonLinkedList.Checked==true)
                radioButtonLinkedList_CheckedChanged(sender, e);
            else if(radioButtonTree.Checked==true)
                radioButtonTree_CheckedChanged(sender, e);
        }
        //...............................Menu Strip...........................................//
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDataStructure.Show();
            groupBoxDataStructure_Enter(sender, e);
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.Show();
        }
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)// Selecting New DataStructure
        {

            DialogResult dialogeResult = MessageBox.Show(" Are You Sure ", "New Data Structure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogeResult == DialogResult.Yes)
            {
                groupBoxInput.Hide();
                groupBoxOptionsStack.Hide();
                groupBoxOptionsLinkedList.Hide();
                groupBoxOptionsTree.Hide();
                groupBoxDataStructure.Show();
                groupBoxDataStructure_Enter(sender, e);
                top = null;
            }
        }
        //...........................................Linked List Options............................//
        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
        //............................................Tree Options.................................//
        //........................................Insert Button Method.............................//
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                node N;
                N = top;
                int number = Int32.Parse(textBoxForInput.Text);
                if (N == null)
                {
                    x_axisShape = tabPageSimulation.Width / 2;
                    y_axisShape = 0;
                    node newNode = new node(number, x_axisShape, y_axisShape);
                    DrawShape(number, x_axisShape, y_axisShape);
                    top = newNode;
                    return;
                }
                node currentNode = top;
                bool added = false;
                do
                {
                    if (number < currentNode.value)
                    {
                        if (currentNode.left == null)
                        {

                            x_axisShape = currentNode.x_axis - 50;
                            y_axisShape = currentNode.y_axis + 50;
                            DrawEdge(currentNode.x_axis + 5, currentNode.y_axis + 20, x_axisShape + 20, y_axisShape + 5);
                            node newNode = new node(number, x_axisShape, y_axisShape);
                            DrawShape(number, x_axisShape, y_axisShape);
                            currentNode.left = newNode;
                            added = true;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    if (number >= currentNode.value)
                    {
                        if (currentNode.right == null)
                        {
                            x_axisShape = currentNode.x_axis + 50;
                            y_axisShape = currentNode.y_axis + 50;
                            DrawEdge(currentNode.x_axis + 20, currentNode.y_axis + 20, x_axisShape + 5, y_axisShape + 5);
                            node newNode = new node(number, x_axisShape, y_axisShape);
                            DrawShape(number, x_axisShape, y_axisShape);
                            currentNode.right = newNode;
                            added = true;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                } while (!added);
                
            }
            catch
            {
                labelOnlyInteger.Text = "Only Integers Are Allowed".ToString();
                textBoxForInput.Clear();
            }
        }
        //........................................Find Button Method.............................//
        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                node searchNode = null;
                int value = Int32.Parse(textBoxForInput.Text);
                if (searchNode == null)
                {
                    searchNode = top;
                }
                searchNodeInTree(ref searchNode, value);
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
        }
        private void searchNodeInTree(ref node N,int value)
            {
                if (N.value == value)
                {
                    SearchDrawShape(N.x_axis,N.y_axis);
                    return;
                }
                else
                {
                    if (value < N.value)
                    {
                        searchNodeInTree(ref N.left, value);
                        return;
                    }
                    if (value >= N.value)
                    {
                        searchNodeInTree(ref N.right, value);
                        return;
                    }
                }
            }
        //.........................................Delete Node Button................................................//
        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        //.........................................Paint Event.................................................//
        private void tabPageSimulation_Paint(object sender, PaintEventArgs e)
        {
          
           
        }
        //.........................................Creating Graphics.........................................//
        public void DrawShape(int num, int x, int y)
        {
            Graphics g = tabPageSimulation.CreateGraphics();
            Brush b = new SolidBrush(Color.Blue);
            Pen p = new Pen(b, 4);
            Font font = new Font("Arial", 12);
            g.DrawString(num.ToString(), font, b , x+5 ,y+4);
            g.DrawEllipse(p,x,y,26,26);
        }
        //...........................................Search Node Draw.......................................//
        public void SearchDrawShape(int x, int y)
        {
            Graphics g = tabPageSimulation.CreateGraphics();
            Pen p = new Pen(Brushes.Red,5);
            g.DrawEllipse(p, x, y, 28, 29);
        }
        //............................................Draw Edge.............................................//
        public void DrawEdge(int x1,int y1,int x2,int y2)
        {
            var point1 = new Point(x1, y1);
            var point2 = new Point(x2, y2);
            Graphics g = tabPageSimulation.CreateGraphics();
            Brush b = new SolidBrush(Color.Blue);
            Pen p = new Pen(b, 4);
            p.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(p,point1,point2);
        }

        private void textBoxForInput_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
