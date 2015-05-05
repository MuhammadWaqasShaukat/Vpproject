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
            public int startLineX, startLineY, endLineX, endLineY;
            //................................Initial Constructor..........................//
            public node(int value)
            {

            }

            //............................Constructor For Tree ............................//
            public node(int value, int x_axis, int y_axis, int startLineX, int startLineY, int endLineX, int endLineY)
            {
                this.value = value;
                left = null;
                right = null;
                this.x_axis = x_axis;
                this.y_axis = y_axis;
                this.startLineX = startLineX;
                this.startLineY = startLineY;
                this.endLineX = endLineX;
                this.endLineY = endLineY;
            }
            //..........................Constructor For Stack.............................//
            public node(int value, int x_axis,int y_axis)
            {
                this.value = value;
                left = null;  // next would be used as next 
                this.x_axis = x_axis;
                this.y_axis = y_axis;               
            }
            //........................Constructor for Linked List...........................//
        }
        node top = null;
        public int width;
        public int height;
        public int x_axisShape;
        public int y_axisShape;
        public int initialX, initialY, finalX, finalY;//edge;
        Graphics graphics;
        Brush brush;
        Pen pen;
        Bitmap image;
        Font font;
        int count=0;
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
            groupBoxInformation.Show();
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
            else if (radioButtonLinkedList.Checked == true)
                radioButtonLinkedList_CheckedChanged(sender, e);
            else if (radioButtonTree.Checked == true)
                radioButtonTree_CheckedChanged(sender, e);
        }
        //...............................Menu Strip...........................................//
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDataStructure.Show();
            groupBoxDataStructure_Enter(sender, e);
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
        //...........................................Stack Options............................//
        //........................................... Push............................//
        private void buttonPush_Click(object sender, EventArgs e)
        {
            bool added = false;
            try
            {
                actionLable.Text = "Push".ToString();
                x_axisShape = tabPageSimulation.Width / 2;
                int number = Int32.Parse(textBoxForInput.Text);
                if (top == null)
                {
                    y_axisShape = tabPageSimulation.Height - 100;
                    node newNode = new node(number, x_axisShape, y_axisShape);
                    drawStack(ref newNode);
                    top = newNode;
                    drawTop();
                    countLable.Text = (++count).ToString();
                    return;
                }
                node current = top;
                do
                {
                    if (current.left == null)
                    {
                        y_axisShape = current.y_axis - 50;
                        node newNode = new node(number, x_axisShape, y_axisShape);
                        current.left = newNode;
                        drawStack(ref newNode);
                        tabPageSimulation.Refresh();
                        repaintStack();
                        drawTop();
                        added = true;
                        countLable.Text = (++count).ToString();
                    }
                    else
                    {
                        current = current.left;
                    }
                } while (!added);
            }
            catch
            {
                MessageBox.Show("Some thing went Wrong");
            }
        }
       //...........................................pop............................//
        private void buttonPop_Click(object sender, EventArgs e)
        {
            pop();
            tabPageSimulation.Refresh();
            repaintStack();
            drawTop();
        } 
        private void pop()
        {
            try
            {
                actionLable.Text = "Pop".ToString();
                if (top == null)
                {
                    MessageBox.Show("Stack is Empty Stop Poping");
                }
                else if (top.left == null)
                {
                    top = null;
                    countLable.Text = (--count).ToString();
                    return;
                    
                }
                else
                {
                    node prev = top;
                    node current = top.left;
                    while (current.left != null)
                    {
                        prev = current;
                        current = current.left;
                    }
                    prev.left = null;
                    countLable.Text = (--count).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Top is Now Null");
            }
           
           }
        
        public void drawStack(ref node current)
        {
            graphics = tabPageSimulation.CreateGraphics();
            pen = new Pen(Brushes.Blue, 5);
            Font font = new Font("Arial", 12);
            Brush b = new SolidBrush(Color.Blue);
            graphics.DrawString(current.value.ToString(), font, b, current.x_axis+30, current.y_axis+20);
            graphics.DrawRectangle(pen, current.x_axis, current.y_axis, 100, 50);
        }
        public void drawTop()
        {
            try
            {
                node prev = top;
                node current = top.left;
                while (current != null)
                {
                    prev = current;
                    current = current.left;
                }
                graphics = tabPageSimulation.CreateGraphics();
                brush = new SolidBrush(Color.Red);
                pen = new Pen(brush, 4);
                pen.EndCap = LineCap.ArrowAnchor;
                font = new Font("Arial", 12);
                string text = "Top";
                var point1 = new Point(prev.x_axis - 60, prev.y_axis + 20);
                var point2 = new Point(prev.x_axis, prev.y_axis + 20);
                graphics.DrawString(text, font, brush, prev.x_axis - 100, prev.y_axis + 10);
                graphics.DrawLine(pen, point1, point2);
                topLabel.Text = prev.value.ToString();
           }
            catch
            {
                //
            }
        }
        private void repaintStack()
        {
           node N = top;
           while(N!=null)      
            {
               drawStack(ref N);
               N = N.left;
            }
           drawTop();
        }
        //...........................................Linked List Options............................//
        private void buttonAdd_Click(object sender, EventArgs e)
        {
             
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
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
                    initialX = 0;
                    initialY = 0;
                    finalX = 0;
                    finalY = 0;
                    node newNode = new node(number, x_axisShape, y_axisShape, initialX, initialY, finalX, finalY);
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
                            initialX = currentNode.x_axis + 5;
                            initialY = currentNode.y_axis + 20;
                            finalX = x_axisShape + 20;
                            finalY = y_axisShape + 5;
                            node newNode = new node(number, x_axisShape, y_axisShape, initialX, initialY, finalX, finalY);
                            DrawEdge(initialX, initialY, finalX, finalY);
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
                            initialX = currentNode.x_axis + 20;
                            initialY = currentNode.y_axis + 20;
                            finalX = x_axisShape + 5;
                            finalY = y_axisShape + 5;
                            node newNode = new node(number, x_axisShape, y_axisShape, initialX, initialY, finalX, finalY);
                            DrawEdge(initialX, initialY, finalX, finalY);
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
        private void searchNodeInTree(ref node N, int value)
        {
            if (N.value == value)
            {
                SearchDrawShape(N.x_axis, N.y_axis);
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
            graphics = tabPageSimulation.CreateGraphics();
            brush = new SolidBrush(Color.Blue);
            pen = new Pen(brush, 4);
            Font font = new Font("Arial", 12);
            graphics.DrawString(num.ToString(), font, brush, x + 5, y + 4);
            graphics.DrawEllipse(pen, x, y, 26, 26);
        }
        //...........................................Search Node Draw.......................................//
        public void SearchDrawShape(int x, int y)
        {
            graphics = Graphics.FromImage(image);
            graphics = tabPageSimulation.CreateGraphics();
            pen = new Pen(Brushes.Red, 5);
            graphics.DrawEllipse(pen, x, y, 28, 29);
        }
        //............................................Draw Edge.............................................//
        public void DrawEdge(int x1, int y1, int x2, int y2)
        {
            graphics = Graphics.FromImage(image);
            var point1 = new Point(x1, y1);
            var point2 = new Point(x2, y2);
            graphics = tabPageSimulation.CreateGraphics();
            brush = new SolidBrush(Color.Blue);
            pen = new Pen(brush, 4);
            pen.EndCap = LineCap.ArrowAnchor;
            graphics.DrawLine(pen, point1, point2);
        }

        private void dataStructureSimulator_Load(object sender, EventArgs e)
        {
            image = new Bitmap(tabControlDsSimulator.ClientSize.Width, tabControlDsSimulator.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(radioButtonTree .Checked==true)
            repaintTree(ref top);
            if (radioButtonStack.Checked == true)
            repaintStack();
            
        }
        private void repaintTree(ref node root)
        {
            if (root != null)
            {
                DrawEdge(root.startLineX, root.startLineY, root.endLineX, root.endLineY);
                DrawShape(root.value, root.x_axis, root.y_axis);
                repaintTree(ref root.left);
                repaintTree(ref root.right);
            }
            else return;

        }

        private void vScrollBarSimulator_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tabPageSimulation_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSimulation_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

    



     
    }
}
