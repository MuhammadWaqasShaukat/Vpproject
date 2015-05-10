using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
           public node(int value, node next, int x,int y)
            {
                this.value = value;
                this.left = next;
                this.x_axis = x;
                this.y_axis = y;
            }
        }
        //....................................Vaiables Used............................................................//
        node top = null;
        public int width;
        public int height;
        public int x_axisShape;
        public int y_axisShape;
        public int initialX, initialY, finalX, finalY;//edge;
        Graphics graphics;
        Brush brush = new SolidBrush(Color.Blue);
        Pen pen= new Pen(Brushes.Blue, 2);
        Font font=new Font("Arial", 12);
        int count=0;
        //..........................................About Form.........................................................//
        public dataStructureSimulator()
        {
            InitializeComponent();
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
        private void dataStructureSimulator_MinimumSizeChanged(object sender, EventArgs e)
        {
            repaintTree(ref top);
        }
        private void dataStructureSimulator_MaximumSizeChanged(object sender, EventArgs e)
        {
            repaintTree(ref top);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (radioButtonTree.Checked == true)
                repaintTree(ref top);
            if (radioButtonStack.Checked == true)
                repaintStack();
            if (radioButtonLinkedList.Checked == true)
                repaintLinkedList();
        }
        private void tabPageSimulation_Paint(object sender, PaintEventArgs e)
        {


        }
        private void dataStructureSimulator_Load(object sender, EventArgs e)
        {
        }
        private void buttonNewSimulation_Click(object sender, EventArgs e)
        {
            if (top != null)
            {
                top = null;
                tabPageSimulation.Refresh();
            }
        }
        //......................................radio Buttons..........................................................//
        private void radioButtonStack_CheckedChanged(object sender, EventArgs e)
        {
            dataStructureUsed.Text = radioButtonStack.Text.ToString();
            buttonNewSimulation.Text = "New Stack".ToString();
            groupBoxInput.Show();
            groupBoxOptionsStack.Show();
            groupBoxInformation.Show();
        }
        private void radioButtonLinkedList_CheckedChanged(object sender, EventArgs e)
        {
            dataStructureUsed.Text = radioButtonLinkedList.Text.ToString();
            buttonNewSimulation.Text = "New Linked List".ToString();
            groupBoxInput.Show();
            groupBoxOptionsLinkedList.Show();
        }
        private void radioButtonTree_CheckedChanged(object sender, EventArgs e)
        {
            dataStructureUsed.Text = radioButtonTree.Text.ToString();
            buttonNewSimulation.Text = "New Tree".ToString();
            groupBoxInput.Show();
            groupBoxOptionsTree.Show();
        }
        //.............................Group Box DataStructures........................................................//
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
        //...............................Menu Strip....................................................................//
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
                tabPageSimulation.Refresh();
            }
        }
        //...........................................Stack Options.....................................................//
        //........................................... Push.............................................................//
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
       //..............................................pop.............................................................//
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
        //.........................................Graphics Stack......................................................//
        public void drawStack(ref node current)
        {
            graphics = tabPageSimulation.CreateGraphics();
            graphics.DrawString(current.value.ToString(), font, brush, current.x_axis+30, current.y_axis+20);
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
                pen.EndCap = LineCap.ArrowAnchor;
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
        //..........................................Linked List Opt.ions...............................................//
        //.................................................Add.........................................................//
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonAddAtStartLinkedList.Checked == true) {  addAtStart(); }
                if (radioButtonAddAtMiddleLinkedList.Checked == true) { addAtMiddle(); }
                if (radioButtonAddAtEndLinkedList.Checked == true) { addAtEnd(); }
            }
            catch
            {
                MessageBox.Show("You Have To Select Between The 'Start','Middle' And 'End' Before Adding Data", "Make Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void addAtStart()
        {
            node current = top;
            try
            {
                if (current == null)
                {
                    x_axisShape = 200;
                    y_axisShape = 200;
                    node newNode = new node(Int32.Parse(textBoxForInput.Text), top, x_axisShape, y_axisShape);
                    drawLinkedList(ref newNode);
                    top = newNode;
                }
                else
                {
                    x_axisShape = current.x_axis - 100;
                    y_axisShape = current.y_axis - 50;
                    node newNode = new node(Int32.Parse(textBoxForInput.Text), top, x_axisShape, y_axisShape);
                    drawLinkedList(ref newNode);
                    DrawEdgeList(newNode, current);
                    top = newNode;
                    newNode.x_axis = 200;
                    newNode.y_axis = 200;
                    upDatePositions(ref newNode);
                    repaintLinkedList();
                }
            }
            catch
            {
                MessageBox.Show("Make Sure You've Selected The Right Place To Enter Data", "Add AT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void addAtMiddle()
        {
            textBoxAddAfter.Enabled = true;
            node current = top;
            try
            {
                if (top == null)
                {
                    addAtStart();
                }
                int key = Int32.Parse(textBoxAddAfter.Text);
                while (current != null)
                {
                    if (current.value == key)
                    {
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                node temp = current.left;
                x_axisShape = temp.x_axis - 50;
                y_axisShape = temp.y_axis - 100;
                node newNode = new node(Int32.Parse(textBoxForInput.Text), temp, x_axisShape, y_axisShape);
                current.left = newNode;
                drawLinkedList(ref newNode);
                Thread.Sleep(500);
                DrawEdgeList(current, newNode);
                Thread.Sleep(500);
                DrawEdgeList(newNode, temp);
                Thread.Sleep(500);
                Thread.Sleep(500);
                newNode.x_axis = temp.x_axis;
                newNode.y_axis = temp.y_axis;
                upDatePositions(ref newNode);
                repaintLinkedList();
            }
            catch
            {
                MessageBox.Show("Make Sure You've Selected The Right Place To Enter Data", "Add AT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void addAtEnd()
        {
            node current = top;
            try
            {
                    while (current.left != null)
                    {
                        current = current.left;
                    }
                    x_axisShape = current.x_axis;
                    y_axisShape = current.y_axis;
                    node newNode = new node(Int32.Parse(textBoxForInput.Text), null, x_axisShape, y_axisShape);
                    drawLinkedList(ref newNode);
                    DrawEdgeList(current, newNode);
                    current.left = newNode;
                    newNode.x_axis = current.x_axis + 120;
                    newNode.y_axis = current.y_axis;
                    current.left = newNode;
                    drawLinkedList(ref newNode);
                    repaintLinkedList();
            }
            catch
            {
                MessageBox.Show("Make Sure You've Selected The Right Place To Enter Data", "Add AT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //..................................................Search.....................................................//
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            graphics = tabPageSimulation.CreateGraphics();
            pen = new Pen(Brushes.Red, 4);
            node current = top;
            while(current!=null)
            {
                if (Int32.Parse(textBoxForInput.Text) == current.value)
                {
                    graphics.DrawString("Here it is".ToString(), DefaultFont, Brushes.Black, current.x_axis + 15, current.y_axis - 50);
                    graphics.DrawRectangle(pen, current.x_axis, current.y_axis, 70, 40);
                    break;
                }
                else
                {
                    graphics.DrawRectangle(Pens.Red, current.x_axis, current.y_axis, 70, 40);
                    Thread.Sleep(350);
                    graphics.DrawRectangle(Pens.Blue, current.x_axis, current.y_axis, 70, 40);
                    current = current.left;   
                }
            }
        }
        //..................................................Delete.....................................................//
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonAddAtStartLinkedList.Checked == true) { deleteAtStart(); }
                else if (radioButtonAddAtMiddleLinkedList.Checked == true) { deleteAtMiddle(); }
                else if (radioButtonAddAtEndLinkedList.Checked == true) { deleteAtEnd(); }
            }
            catch { }
        }
        private void deleteAtStart()
        {
            try
            {
                node current = top;
                top = current.left;
                current = null;
                top.x_axis = 200;
                top.y_axis = 200;
                upDatePositions(ref top);
                repaintLinkedList();
            }
          catch
            {
              MessageBox.Show("List Is Already Empty"," Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void deleteAtMiddle()
        {
            try
            {
                node prev = top;
                node current = top.left;
                if (prev.left == null)
                {
                    deleteAtStart();
                }
                else
                {
                    int key = Int32.Parse(textBoxAddAfter.Text);
                    while (current != null)
                    {
                        if (current.value == key)
                        {
                            prev.left = current.left;
                            current.left = null;
                            upDatePositions(ref prev);
                            repaintLinkedList();
                            break;
                        }
                        else
                        {
                            prev = current;
                            current = current.left;
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void deleteAtEnd()
        {
            try
            {
                node prev = top;
                node current = top.left;
                while (current.left != null)
                {
                    prev = current;
                    current = current.left;
                }
                prev.left = null;
                repaintLinkedList();
            }
            catch
            {
                MessageBox.Show("List Is Already Empty", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void radioButtonAddAtMiddleLinkedList_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAddAfter.Enabled = true;
        }
        private void radioButtonAddAtStartLinkedList_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxAddAfter.Enabled == true)
                textBoxAddAfter.Enabled = false;
        }

        private void radioButtonAddAtEndLinkedList_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxAddAfter.Enabled == true)
                textBoxAddAfter.Enabled = false;
        }
        //..............................................UpdatingList...................................................//
        private void upDatePositions(ref node current)
        {
             while(current.left!=null)
             {
               current.left.x_axis += 120;
               current = current.left;
              }
         }
        //...............................................Graphics Linked List..........................................//     
        public void DrawEdgeList(node first, node second)
        {
            graphics = tabPageSimulation.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            initialX = first.x_axis + 60;
            initialY = first.y_axis + 20;
            finalX = second.x_axis;
            finalY = second.y_axis + 20;
            var point1 = new Point(initialX, initialY);
            var point2 = new Point(finalX, finalY);
            pen.EndCap = LineCap.ArrowAnchor;
            pen.StartCap = LineCap.RoundAnchor;
            graphics.DrawLine(pen, point1, point2);
        }
        private void drawLinkedList(ref node current)
        {
            graphics = tabPageSimulation.CreateGraphics();
            graphics.DrawString(current.value.ToString(), font, brush, current.x_axis + 15, current.y_axis + 10);
            graphics.DrawRectangle(pen, current.x_axis, current.y_axis, 70, 40);
            graphics.DrawRectangle(pen, current.x_axis, current.y_axis, 50, 40);
        } 
        private void repaintLinkedList()
        {
            node current = top;
            tabPageSimulation.Refresh();
            while(current!=null)
            {
                drawLinkedList(ref current);
                if (current.left != null)
                {
                    DrawEdgeList(current, current.left);
                }
                current = current.left;
            }
        }
        private void DrawNull(ref node current)
        {

        }
        //................................................Tree Options.................................................//
        //....................................................Insert...................................................//
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
        //....................................................Find.....................................................//
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
        //....................................................Delete...................................................//
        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        //................................................Graphics Tree................................................//
        public void DrawShape(int num, int x, int y)
        {
            graphics = tabPageSimulation.CreateGraphics();
            graphics.DrawString(num.ToString(), font, brush, x + 5, y + 4);
            graphics.DrawEllipse(pen, x, y, 26, 26);
        }
        public void SearchDrawShape(int x, int y)
        {
            graphics = tabPageSimulation.CreateGraphics();
            pen = new Pen(Brushes.Red, 5);
            graphics.DrawEllipse(pen, x, y, 28, 29);
        }
        public void DrawEdge(int x1, int y1, int x2, int y2)
        {
            var point1 = new Point(x1, y1);
            var point2 = new Point(x2, y2);
            graphics = tabPageSimulation.CreateGraphics();
            pen.EndCap = LineCap.ArrowAnchor;
            graphics.DrawLine(pen, point1, point2);
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
    }
}
