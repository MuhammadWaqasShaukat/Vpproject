using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Data_Structure_Simulator
{
    class treeImplentaion : dataStructureSimulator
    {
         public  class node
        {
            public int value;
            public node left;
            public node right;
            public int level;
            public int x_axis;
            public int y_axis;
            public node(int value,int x,int y)
            {
                this.value = value;
                left = null;
                right = null;
                x_axis = x;
                y_axis = y;
            }
        }
        public int width, height, x_axisShape, y_axisShape;
        node top = null;
        public void insert(string value)
        {
            int number = Int32.Parse(value);
            Add(ref top, number);
        }
        public void Add(ref node N,int value)
          {
               if(N==null)
                  {
                      x_axisShape = tabPageSimulation.Width / 2;
                      y_axisShape = 0;
                     node newNode= new node(value,x_axisShape,y_axisShape);
                     DrawShape(value,x_axisShape, y_axisShape);
                     top=newNode;
                     return;
                  }
                     node currentNode=top;
                     bool added=false;
               do{
                  if(value<currentNode.value)
                     {
                     if(currentNode.left==null)
                     {
                     x_axisShape = currentNode.x_axis - 50;
                     y_axisShape = currentNode.y_axis+50;
                     node newNode = new node(value,x_axisShape,y_axisShape);
                     DrawShape(value,x_axisShape, y_axisShape);
                     currentNode.left=newNode;
                     added=true;
                     }
                     else
                     {
                     currentNode=currentNode.left;
                     }
                     }
                  if (value >= currentNode.value)
                  {
                      if (currentNode.right == null)
                      {
                          if (value == currentNode.value)
                          {
                              x_axisShape = currentNode.x_axis + 25;
                          }
                          else 
                          x_axisShape = currentNode.x_axis + 50;
                          y_axisShape = currentNode.y_axis + 50;
                          node newNode = new node(value, x_axisShape, y_axisShape);
                          DrawShape(value,x_axisShape, y_axisShape);
                          currentNode.right = newNode;
                          added = true;
                      }
                      else
                      {
                          currentNode = currentNode.right;
                      }
                  }
             }while(!added);
   }
       //...............................................................
        public void DrawShape(int num,int x,int y)
        {

           /// Draw(num, x, y);
            //Graphics g = tabPageSimulation.CreateGraphics();
            //Brush b = new SolidBrush(Color.Blue);
            //Pen p = new Pen(b, 2);
            //using (Font font1 = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point))
            //{
            //    RectangleF rectF1 = new Rectangle(x, y, 25, 25);
            //    g.DrawString(num.ToString(), font1, Brushes.Blue, rectF1);
            //    g.DrawEllipse(p, Rectangle.Round(rectF1));
            //}
                        
        }
        
        
        //...................................................................
        public void display()
        {
            
        }
    }

}
