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
                left = null;  // left would be used as next 
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
        Pen pen= new Pen(Brushes.Blue, 4);
        Font font=new Font("Arial", 12);
        Font msgFont = new Font("Arial", 15);
        Pen searchPen = new Pen(Brushes.Red, 4);
        int count=0;
        //..........................................About Form.........................................................//
        public dataStructureSimulator()
        {
            InitializeComponent();
        }
      protected override void OnPaint(PaintEventArgs e)
        {
            canvas.Refresh();
            base.OnPaint(e);
            if (radioButtonTree.Checked == true)
                repaintTree(ref top);
            if (radioButtonStack.Checked == true)
                repaintStack();
            if (radioButtonLinkedList.Checked == true)
                repaintLinkedList();
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
        }
        //......................................radio Buttons..........................................................//
        private void radioButtonStack_CheckedChanged(object sender, EventArgs e)
        {
            dataStructureUsed.Text = radioButtonStack.Text.ToString();
            labelHowItWorks.Text = "1 :- You can Push the data onto Stack and you can Pop the data from Stack.\n2 :-Deletetion and Addition can be perform only from one end.\n3 :-Because its LIFO structure 'Last In First Out Structure'.\n4 :- Data that been pushed last will be out first".ToString();
            groupBoxOperationsTree.Enabled = false;
            groupBoxOperationsLinkedList.Enabled = false;
            groupBoxOperationsStack.Enabled = true;
            groupBoxInput.Enabled = true;
            groupBoxDataStructure.Enabled = false;
        }
        private void radioButtonLinkedList_CheckedChanged(object sender, EventArgs e)
        {

            dataStructureUsed.Text = radioButtonLinkedList.Text.ToString();
            labelHowItWorks.Text = "1 :- You can Insert the data into Linked List anywhere you want at  Start , Middle , End .\n2 :- You can Delete the data from Linked List anywhere you want at  Start , Middle , End '.\n3 :- Before inserting or deleting the data you have to select Between  Start , Middle  or  End buttons.\n4 :- Searching can be performed in whole List.\n5 :- While adding in Middle of the list you have to provide the input in this way \n       [the number after you want to Enter, new number which would be add]\n      like this num1,num2 number must be seprated by coma symbol(,) ".ToString();
            groupBoxOperationsStack.Enabled = false;
            groupBoxOperationsLinkedList.Enabled = true;
            groupBoxOperationsTree.Enabled = false;
            groupBoxInput.Enabled = true;
            groupBoxDataStructure.Enabled = false;
        }
        private void radioButtonTree_CheckedChanged(object sender, EventArgs e)
        {
            dataStructureUsed.Text = radioButtonTree.Text.ToString();
            labelHowItWorks.Text = "1 :- You can Insert the data into Tree.\n2 :- You can Delete the data from the tree.\n3 :- Searching can be performed in whole tree.\n4 :- The data which would be less then the root's node value will go left of the root node.\n5 :- The data which would be greater then the root's node value will go right of the root node.".ToString();
            groupBoxOperationsStack.Enabled = false;
            groupBoxOperationsTree.Enabled = true;
            groupBoxOperationsLinkedList.Enabled = false;
            groupBoxInput.Enabled = true;
            groupBoxDataStructure.Enabled = false;
        }
        //.............................Group Box DataStructures........................................................//
        private void groupBoxDataStructure_Enter(object sender, EventArgs e)
        {
            groupBoxDataStructure.Enabled = true;
            if (radioButtonStack.Checked == true)
            {
                radioButtonStack_CheckedChanged(sender, e);
            }
            else if (radioButtonLinkedList.Checked == true)
                radioButtonLinkedList_CheckedChanged(sender, e);
            else if (radioButtonTree.Checked == true)
                radioButtonTree_CheckedChanged(sender, e);
        }
        //...............................Menu Strip....................................................................//
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDataStructure_Enter(sender, e);
        }
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)// Selecting New DataStructure
        {
            
            DialogResult dialogeResult = MessageBox.Show(" Are You Sure You Want Create New Simulation ", "New",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogeResult == DialogResult.Yes)
            {
                if (radioButtonLinkedList.Checked || radioButtonStack.Checked || radioButtonTree.Checked == true)
                {
                    radioButtonTree.Checked = radioButtonStack.Checked = radioButtonLinkedList.Checked = false;
                }
                groupBoxInput.Enabled = false;
                groupBoxOperationsStack.Enabled = false;
                groupBoxOperationsLinkedList.Enabled = false;
                groupBoxOperationsTree.Enabled = false;
                groupBoxDataStructure_Enter(sender, e);
                top = null;
                canvas.Refresh();
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
                x_axisShape = canvas.Width / 2;
                int number = Int32.Parse(textBoxForInput.Text);
                if (top == null)
                {
                    y_axisShape = canvas.Height - 100;
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
                        canvas.Refresh();
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
            canvas.Refresh();
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
            graphics = canvas.CreateGraphics();
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
                graphics = canvas.CreateGraphics();
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
                    Thread.Sleep(500);
                    DrawEdgeList(newNode, current);
                    Thread.Sleep(500);
                    top = newNode;
                    newNode.x_axis = 200;
                    newNode.y_axis = 200;
                    upDatePositions(ref newNode);
                    repaintLinkedList();
                }
                topLabel.Text = textBoxForInput.Text.ToString();
                actionLable.Text = "Add At Start".ToString();
                countLable.Text = (++count).ToString();
            }
            catch
            {
                MessageBox.Show("Intergers Are Allowed Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxForInput.Clear();
            }
        }
        private void addAtMiddle()
        {
             
            try
            {
                if (top != null)
                {
                    string value = textBoxForInput.Text;
                    string[] tempstr = value.Split(',');
                    node current = searchNode(Int32.Parse(tempstr[0]));
                    node temp = current.left;
                    x_axisShape = temp.x_axis - 75;
                    y_axisShape = temp.y_axis - 50;
                    node newNode = new node(Int32.Parse(tempstr[1]), temp, x_axisShape, y_axisShape);
                    current.left = newNode;
                    drawLinkedList(ref newNode);
                    Thread.Sleep(500);
                    DrawEdgeList(current, newNode);
                    Thread.Sleep(500);
                    DrawEdgeList(newNode, temp);
                    Thread.Sleep(500);
                    newNode.x_axis = temp.x_axis;
                    newNode.y_axis = temp.y_axis;
                    upDatePositions(ref newNode);
                    repaintLinkedList();
                }
                actionLable.Text = "Add At Middle".ToString();
                countLable.Text = (++count).ToString();
            }
            catch
            {
                MessageBox.Show("Intergers Are Allowed Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxForInput.Clear();
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
                    x_axisShape = current.x_axis+100;
                    y_axisShape = current.y_axis-50;
                    node newNode = new node(Int32.Parse(textBoxForInput.Text), null, x_axisShape, y_axisShape);
                    drawLinkedList(ref newNode);
                    Thread.Sleep(500);
                    DrawEdgeList(current, newNode);
                    Thread.Sleep(500);
                    current.left = newNode;
                    newNode.x_axis = current.x_axis+ 150;
                    newNode.y_axis = current.y_axis;
                    current.left = newNode;
                    drawLinkedList(ref newNode);
                    repaintLinkedList();
                    actionLable.Text = "Add At End".ToString();
                    countLable.Text = (++count).ToString();                    
            }
            catch
            {
                MessageBox.Show("Intergers Are Allowed Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { textBoxForInput.Clear(); }
        }
        //..................................................Search.....................................................//
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                int key = Int32.Parse(textBoxForInput.Text);
               node temp = searchNode(key);
               actionLable.Text = "Searching".ToString();
            }
            catch
            {
                MessageBox.Show("Not Found In the Current Collection", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { textBoxForInput.Clear(); }
            
        }
        //.....................................................Searching...............................................//
        private node searchNode(int key)
        {
            graphics = canvas.CreateGraphics();
            node current = top;
            while (current != null)
            {
                if (key == current.value)
                {
                    graphics.DrawRectangle(searchPen, current.x_axis, current.y_axis, 70, 40);
                    Thread.Sleep(1000);
                    repaintLinkedList();
                    return current;
                }
                else
                {
                    graphics.DrawRectangle(searchPen, current.x_axis, current.y_axis, 70, 40);
                    Thread.Sleep(350);
                    graphics.DrawRectangle(pen, current.x_axis, current.y_axis, 70, 40);
                    current = current.left;
                }
            }
            return null;
        }
        //..................................................Delete.....................................................//
        private void buttonRemove_Click(object sender, EventArgs e)
        {
                if (radioButtonAddAtStartLinkedList.Checked == true) { deleteAtStart(); }
                else if (radioButtonAddAtMiddleLinkedList.Checked == true) { deleteAtMiddle(); }
                else if (radioButtonAddAtEndLinkedList.Checked == true) { deleteAtEnd(); }
        }
        private void deleteAtStart()
        {
            try
            {
                
                node current = top;
                graphics.DrawRectangle(searchPen, current.x_axis, current.y_axis, 70, 40);
                Thread.Sleep(500);
                if (current.left == null)
                {
                    topLabel.Text = "null".ToString();
                    top = null;
                }
                else
                {
                    top = current.left;
                    current = null;
                    top.x_axis = 200;
                    top.y_axis = 200;
                    topLabel.Text = top.value.ToString();
                }
               // upDatePositions(ref top);
                repaintLinkedList();
                actionLable.Text = "Delete At Start".ToString();
                countLable.Text = (--count).ToString();
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
                int key = Int32.Parse(textBoxForInput.Text);
                while (current != null)
                {
                 if (current.value == key)
                   {
                            graphics.DrawRectangle(searchPen, current.x_axis, current.y_axis, 70, 40);
                            Thread.Sleep(500);
                            prev.left = current.left;
                            current.left = null;
                            //upDatePositions(ref prev);
                            repaintLinkedList();
                            break;
                    }
                  else
                    {
                            prev = current;
                            current = current.left;
                    }
                    
                }
                actionLable.Text = "Delete At Middle".ToString();
                countLable.Text = (--count).ToString();
            }
            catch
            {
                MessageBox.Show("List Is Already Empty", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxForInput.Clear();
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
                graphics.DrawRectangle(searchPen, current.x_axis, current.y_axis, 70, 40);
                Thread.Sleep(500);
                prev.left = null;
                repaintLinkedList();
                actionLable.Text = "Delete At End".ToString();
                countLable.Text = (--count).ToString();
            }
            catch
            {
                MessageBox.Show("List Is Already Empty", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //..............................................UpdatingList...................................................//
        private void upDatePositions(ref node current)
        {
             while(current.left!=null)
             {
               current.left.x_axis+= 150;
               current = current.left;
              }
         }
        //...............................................Graphics Linked List..........................................//     
        public void DrawEdgeList(node first, node second)
        {
            graphics = canvas.CreateGraphics();
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
            graphics = canvas.CreateGraphics();
            graphics.DrawString(current.value.ToString(), font, brush, current.x_axis + 15, current.y_axis + 10);
            graphics.DrawRectangle(pen, current.x_axis, current.y_axis, 70, 40);
            graphics.DrawRectangle(pen, current.x_axis, current.y_axis, 50, 40);
        } 
        private void repaintLinkedList()
        {
            node current = top;
            canvas.Refresh();
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
                    x_axisShape = canvas.Width / 2;
                    y_axisShape = 0;
                    initialX = 0;
                    initialY = 0;
                    finalX = 0;
                    finalY = 0;
                    node newNode = new node(number, x_axisShape, y_axisShape, initialX, initialY, finalX, finalY);
                    DrawShape(number, x_axisShape, y_axisShape);
                    topLabel.Text = newNode.value.ToString();
                    top = newNode;
                }
                else
                {
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
                                initialX = currentNode.x_axis + 2;
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

                actionLable.Text = "Insert".ToString();
                countLable.Text = (++count).ToString();
            }
            catch
            {
                labelOnlyInteger.Text = "Only Integers Are Allowed".ToString();
            }
            finally
            {
                textBoxForInput.Clear();
            }
        }
        //....................................................Find.....................................................//
        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(textBoxForInput.Text);
                node foundNode = SearchingNode(value);
                SearchDrawShape(foundNode.x_axis, foundNode.y_axis);

            }
            catch
            {
                MessageBox.Show("The Number You Intend To Search Is Not Existing", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //private void searchNodeInTree(ref node N, int value)
        //{
        //    if (N.value == value)
        //    {
        //        SearchDrawShape(N.x_axis, N.y_axis);
        //        return;
        //    }
        //    else
        //    {
        //        if (value < N.value)
        //        {
        //            searchNodeInTree(ref N.left, value);
        //        }
        //        if (value >= N.value)
        //        {
        //            searchNodeInTree(ref N.right, value);
        //        }
        //    }
        //}
        public node SearchingNode(int key)
        {
            node Node = null;
            if(top.value==key)
            {
                return top;
            }
           node currentNode=top;
           bool found=false;
           do 
          {
             if(key==currentNode.value)
             {
              found=true;
              Node = currentNode;
              break;
             }
             else
             {
              if(key<currentNode.value)
                currentNode=currentNode.left;
              else 
                currentNode=currentNode.right;
              }
          }while(!found);
            if(found==false)
            {
                Node = null;
            }
            return Node;
       }
        //....................................................Delete...................................................//
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int key = Int32.Parse(textBoxForInput.Text);
            node nodeFound = DeleteN(top, key);//SearchingNode(key);
            if (nodeFound == null)
            {
                MessageBox.Show("The number You Intend to delete is not existing", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                canvas.Refresh();
                repaintTree(ref top);
            }
        }
        //..................................................
private node DeleteN(node root,int key) 
{
    if (root == null)
    {
        return root;
    }
    if (key < root.value)
    {
        root.left = DeleteN(root.left, key);
    }
    if (key > root.value)
    {
        root.right = DeleteN(root.right,key);
    }
    if (key == root.value)
    {
        
        if (root.left == null && root.right == null)
        {
            root = null;
            return root;
        }
       if (root.left == null)
        {
            node temp = root;
            root = root.right;
            root.startLineX = temp.startLineX;
            root.startLineY = temp.startLineY;
            root.x_axis = temp.x_axis;
            root.y_axis = temp.y_axis;
            root.endLineX = temp.endLineX;
            root.endLineY = temp.endLineY;
            temp = null;
        }
        else if (root.right == null)
        {
            node temp = root;
            root = root.left;
            root.startLineX = temp.startLineX;
            root.startLineY = temp.startLineY;
            root.x_axis = temp.x_axis;
            root.y_axis = temp.y_axis;
            root.endLineX = temp.endLineX;
            root.endLineY = temp.endLineY;
            temp = null;
        }
        
        else
        {
            

           
        }
    }
    return root;
}

        //................................................Graphics Tree................................................//
        public void DrawShape(int num, int x, int y)
        {
            try
            {
                graphics = canvas.CreateGraphics();
                graphics.DrawString(num.ToString(), font, brush, x + 5, y + 4);
                graphics.DrawEllipse(pen, x, y, 26, 26);
            }
            catch
            {

            }
        }
        public void SearchDrawShape(int x, int y)
        {
            graphics = canvas.CreateGraphics();
            pen = new Pen(Brushes.Red, 5);
            graphics.DrawEllipse(pen, x, y, 28, 29);
        }
        public void DrawEdge(int x1, int y1, int x2, int y2)
        {
            var pointStart = new Point(x1, y1);
            var pointEnd = new Point(x2, y2);
            graphics = canvas.CreateGraphics();
            pen.EndCap = LineCap.ArrowAnchor;
            graphics.DrawLine(pen, pointStart, pointEnd);
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
