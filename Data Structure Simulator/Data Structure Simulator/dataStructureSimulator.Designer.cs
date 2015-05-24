namespace Data_Structure_Simulator
{
    partial class dataStructureSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataStructureSimulator));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.ShowDataStructureBeingUsed = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxForInput = new System.Windows.Forms.TextBox();
            this.dataStructureUsed = new System.Windows.Forms.Label();
            this.actionLable = new System.Windows.Forms.Label();
            this.labelNumberForInput = new System.Windows.Forms.Label();
            this.labelLastAction = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.labelTopsValue = new System.Windows.Forms.Label();
            this.countLable = new System.Windows.Forms.Label();
            this.groupBoxOperationsStack = new System.Windows.Forms.GroupBox();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.groupBoxOperationsTree = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.groupBoxOperationsLinkedList = new System.Windows.Forms.GroupBox();
            this.labelAddAt = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.radioButtonAddAtEndLinkedList = new System.Windows.Forms.RadioButton();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.radioButtonAddAtMiddleLinkedList = new System.Windows.Forms.RadioButton();
            this.radioButtonAddAtStartLinkedList = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxDataStructure = new System.Windows.Forms.GroupBox();
            this.radioButtonTree = new System.Windows.Forms.RadioButton();
            this.radioButtonLinkedList = new System.Windows.Forms.RadioButton();
            this.radioButtonStack = new System.Windows.Forms.RadioButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.labelHowItWorks = new System.Windows.Forms.Label();
            this.labelOnlyInteger = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOperationsStack.SuspendLayout();
            this.groupBoxOperationsTree.SuspendLayout();
            this.groupBoxOperationsLinkedList.SuspendLayout();
            this.groupBoxDataStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBoxInformation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxInput);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOperationsStack);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOperationsTree);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOperationsLinkedList);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxDataStructure);
            this.splitContainer2.Panel1.Margin = new System.Windows.Forms.Padding(400, 0, 400, 0);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer);
            this.splitContainer2.Size = new System.Drawing.Size(784, 537);
            this.splitContainer2.SplitterDistance = 209;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxInput.Controls.Add(this.ShowDataStructureBeingUsed);
            this.groupBoxInput.Controls.Add(this.labelCount);
            this.groupBoxInput.Controls.Add(this.textBoxForInput);
            this.groupBoxInput.Controls.Add(this.dataStructureUsed);
            this.groupBoxInput.Controls.Add(this.actionLable);
            this.groupBoxInput.Controls.Add(this.labelNumberForInput);
            this.groupBoxInput.Controls.Add(this.labelLastAction);
            this.groupBoxInput.Controls.Add(this.topLabel);
            this.groupBoxInput.Controls.Add(this.labelTopsValue);
            this.groupBoxInput.Controls.Add(this.countLable);
            this.groupBoxInput.Enabled = false;
            this.groupBoxInput.Location = new System.Drawing.Point(6, 66);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(195, 124);
            this.groupBoxInput.TabIndex = 13;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // ShowDataStructureBeingUsed
            // 
            this.ShowDataStructureBeingUsed.AutoSize = true;
            this.ShowDataStructureBeingUsed.Location = new System.Drawing.Point(5, 16);
            this.ShowDataStructureBeingUsed.Name = "ShowDataStructureBeingUsed";
            this.ShowDataStructureBeingUsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowDataStructureBeingUsed.Size = new System.Drawing.Size(79, 13);
            this.ShowDataStructureBeingUsed.TabIndex = 0;
            this.ShowDataStructureBeingUsed.Text = "Data Structure:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(10, 105);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(41, 13);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Count :";
            // 
            // textBoxForInput
            // 
            this.textBoxForInput.Location = new System.Drawing.Point(95, 41);
            this.textBoxForInput.Name = "textBoxForInput";
            this.textBoxForInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxForInput.Size = new System.Drawing.Size(61, 20);
            this.textBoxForInput.TabIndex = 12;
            // 
            // dataStructureUsed
            // 
            this.dataStructureUsed.AutoSize = true;
            this.dataStructureUsed.Location = new System.Drawing.Point(98, 16);
            this.dataStructureUsed.Name = "dataStructureUsed";
            this.dataStructureUsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataStructureUsed.Size = new System.Drawing.Size(0, 13);
            this.dataStructureUsed.TabIndex = 1;
            // 
            // actionLable
            // 
            this.actionLable.AutoSize = true;
            this.actionLable.Location = new System.Drawing.Point(76, 86);
            this.actionLable.Name = "actionLable";
            this.actionLable.Size = new System.Drawing.Size(0, 13);
            this.actionLable.TabIndex = 3;
            // 
            // labelNumberForInput
            // 
            this.labelNumberForInput.AutoSize = true;
            this.labelNumberForInput.Location = new System.Drawing.Point(6, 44);
            this.labelNumberForInput.Name = "labelNumberForInput";
            this.labelNumberForInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNumberForInput.Size = new System.Drawing.Size(78, 13);
            this.labelNumberForInput.TabIndex = 11;
            this.labelNumberForInput.Text = "Enter Number :";
            // 
            // labelLastAction
            // 
            this.labelLastAction.AutoSize = true;
            this.labelLastAction.Location = new System.Drawing.Point(10, 86);
            this.labelLastAction.Name = "labelLastAction";
            this.labelLastAction.Size = new System.Drawing.Size(66, 13);
            this.labelLastAction.TabIndex = 2;
            this.labelLastAction.Text = "Last Action :";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(81, 66);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(0, 13);
            this.topLabel.TabIndex = 1;
            // 
            // labelTopsValue
            // 
            this.labelTopsValue.AutoSize = true;
            this.labelTopsValue.Location = new System.Drawing.Point(9, 66);
            this.labelTopsValue.Name = "labelTopsValue";
            this.labelTopsValue.Size = new System.Drawing.Size(69, 13);
            this.labelTopsValue.TabIndex = 0;
            this.labelTopsValue.Text = "Top\'s Value :";
            // 
            // countLable
            // 
            this.countLable.AutoSize = true;
            this.countLable.Location = new System.Drawing.Point(57, 105);
            this.countLable.Name = "countLable";
            this.countLable.Size = new System.Drawing.Size(0, 13);
            this.countLable.TabIndex = 4;
            // 
            // groupBoxOperationsStack
            // 
            this.groupBoxOperationsStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOperationsStack.Controls.Add(this.buttonPop);
            this.groupBoxOperationsStack.Controls.Add(this.buttonPush);
            this.groupBoxOperationsStack.Enabled = false;
            this.groupBoxOperationsStack.Location = new System.Drawing.Point(6, 196);
            this.groupBoxOperationsStack.Name = "groupBoxOperationsStack";
            this.groupBoxOperationsStack.Size = new System.Drawing.Size(195, 73);
            this.groupBoxOperationsStack.TabIndex = 13;
            this.groupBoxOperationsStack.TabStop = false;
            this.groupBoxOperationsStack.Text = "Stack Operations";
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(95, 19);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(90, 44);
            this.buttonPop.TabIndex = 3;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(6, 19);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(88, 44);
            this.buttonPush.TabIndex = 2;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // groupBoxOperationsTree
            // 
            this.groupBoxOperationsTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOperationsTree.Controls.Add(this.buttonDelete);
            this.groupBoxOperationsTree.Controls.Add(this.buttonFind);
            this.groupBoxOperationsTree.Controls.Add(this.buttonInsert);
            this.groupBoxOperationsTree.Enabled = false;
            this.groupBoxOperationsTree.Location = new System.Drawing.Point(6, 434);
            this.groupBoxOperationsTree.Name = "groupBoxOperationsTree";
            this.groupBoxOperationsTree.Size = new System.Drawing.Size(195, 76);
            this.groupBoxOperationsTree.TabIndex = 0;
            this.groupBoxOperationsTree.TabStop = false;
            this.groupBoxOperationsTree.Text = "Tree Operations";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(125, 15);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 45);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(66, 15);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(60, 45);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(6, 15);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(60, 45);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // groupBoxOperationsLinkedList
            // 
            this.groupBoxOperationsLinkedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOperationsLinkedList.Controls.Add(this.labelAddAt);
            this.groupBoxOperationsLinkedList.Controls.Add(this.buttonSearch);
            this.groupBoxOperationsLinkedList.Controls.Add(this.radioButtonAddAtEndLinkedList);
            this.groupBoxOperationsLinkedList.Controls.Add(this.buttonRemove);
            this.groupBoxOperationsLinkedList.Controls.Add(this.radioButtonAddAtMiddleLinkedList);
            this.groupBoxOperationsLinkedList.Controls.Add(this.radioButtonAddAtStartLinkedList);
            this.groupBoxOperationsLinkedList.Controls.Add(this.buttonAdd);
            this.groupBoxOperationsLinkedList.Enabled = false;
            this.groupBoxOperationsLinkedList.Location = new System.Drawing.Point(6, 273);
            this.groupBoxOperationsLinkedList.Name = "groupBoxOperationsLinkedList";
            this.groupBoxOperationsLinkedList.Size = new System.Drawing.Size(195, 155);
            this.groupBoxOperationsLinkedList.TabIndex = 4;
            this.groupBoxOperationsLinkedList.TabStop = false;
            this.groupBoxOperationsLinkedList.Text = "Linked List Operations";
            // 
            // labelAddAt
            // 
            this.labelAddAt.AutoSize = true;
            this.labelAddAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAt.Location = new System.Drawing.Point(9, 93);
            this.labelAddAt.Name = "labelAddAt";
            this.labelAddAt.Size = new System.Drawing.Size(176, 15);
            this.labelAddAt.TabIndex = 7;
            this.labelAddAt.Text = "Select For Add / Delete Options";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(68, 23);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(58, 46);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // radioButtonAddAtEndLinkedList
            // 
            this.radioButtonAddAtEndLinkedList.AutoSize = true;
            this.radioButtonAddAtEndLinkedList.Location = new System.Drawing.Point(134, 119);
            this.radioButtonAddAtEndLinkedList.Name = "radioButtonAddAtEndLinkedList";
            this.radioButtonAddAtEndLinkedList.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAddAtEndLinkedList.TabIndex = 4;
            this.radioButtonAddAtEndLinkedList.Text = "End";
            this.radioButtonAddAtEndLinkedList.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(129, 24);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(58, 45);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // radioButtonAddAtMiddleLinkedList
            // 
            this.radioButtonAddAtMiddleLinkedList.AutoSize = true;
            this.radioButtonAddAtMiddleLinkedList.Location = new System.Drawing.Point(72, 119);
            this.radioButtonAddAtMiddleLinkedList.Name = "radioButtonAddAtMiddleLinkedList";
            this.radioButtonAddAtMiddleLinkedList.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAddAtMiddleLinkedList.TabIndex = 3;
            this.radioButtonAddAtMiddleLinkedList.Text = "Middle";
            this.radioButtonAddAtMiddleLinkedList.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddAtStartLinkedList
            // 
            this.radioButtonAddAtStartLinkedList.AutoSize = true;
            this.radioButtonAddAtStartLinkedList.Checked = true;
            this.radioButtonAddAtStartLinkedList.Location = new System.Drawing.Point(19, 119);
            this.radioButtonAddAtStartLinkedList.Name = "radioButtonAddAtStartLinkedList";
            this.radioButtonAddAtStartLinkedList.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAddAtStartLinkedList.TabIndex = 2;
            this.radioButtonAddAtStartLinkedList.TabStop = true;
            this.radioButtonAddAtStartLinkedList.Text = "Start";
            this.radioButtonAddAtStartLinkedList.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(8, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(58, 45);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxDataStructure
            // 
            this.groupBoxDataStructure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDataStructure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxDataStructure.Controls.Add(this.radioButtonTree);
            this.groupBoxDataStructure.Controls.Add(this.radioButtonLinkedList);
            this.groupBoxDataStructure.Controls.Add(this.radioButtonStack);
            this.groupBoxDataStructure.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDataStructure.Name = "groupBoxDataStructure";
            this.groupBoxDataStructure.Size = new System.Drawing.Size(195, 54);
            this.groupBoxDataStructure.TabIndex = 0;
            this.groupBoxDataStructure.TabStop = false;
            this.groupBoxDataStructure.Text = "Data Structure";
            this.groupBoxDataStructure.Enter += new System.EventHandler(this.groupBoxDataStructure_Enter);
            // 
            // radioButtonTree
            // 
            this.radioButtonTree.AutoSize = true;
            this.radioButtonTree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonTree.Location = new System.Drawing.Point(143, 19);
            this.radioButtonTree.Name = "radioButtonTree";
            this.radioButtonTree.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTree.TabIndex = 2;
            this.radioButtonTree.Text = "Tree";
            this.radioButtonTree.UseVisualStyleBackColor = false;
            this.radioButtonTree.CheckedChanged += new System.EventHandler(this.radioButtonTree_CheckedChanged);
            // 
            // radioButtonLinkedList
            // 
            this.radioButtonLinkedList.AutoSize = true;
            this.radioButtonLinkedList.Location = new System.Drawing.Point(65, 19);
            this.radioButtonLinkedList.Name = "radioButtonLinkedList";
            this.radioButtonLinkedList.Size = new System.Drawing.Size(76, 17);
            this.radioButtonLinkedList.TabIndex = 1;
            this.radioButtonLinkedList.Text = "Linked List";
            this.radioButtonLinkedList.UseVisualStyleBackColor = true;
            this.radioButtonLinkedList.CheckedChanged += new System.EventHandler(this.radioButtonLinkedList_CheckedChanged);
            // 
            // radioButtonStack
            // 
            this.radioButtonStack.AutoSize = true;
            this.radioButtonStack.Location = new System.Drawing.Point(6, 19);
            this.radioButtonStack.Name = "radioButtonStack";
            this.radioButtonStack.Size = new System.Drawing.Size(53, 17);
            this.radioButtonStack.TabIndex = 0;
            this.radioButtonStack.Text = "Stack";
            this.radioButtonStack.UseVisualStyleBackColor = true;
            this.radioButtonStack.CheckedChanged += new System.EventHandler(this.radioButtonStack_CheckedChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer.Panel1.Controls.Add(this.vScrollBar);
            this.splitContainer.Panel1.Controls.Add(this.hScrollBar);
            this.splitContainer.Panel1.Controls.Add(this.canvas);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer.Panel2.Controls.Add(this.groupBoxInformation);
            this.splitContainer.Panel2.Controls.Add(this.labelOnlyInteger);
            this.splitContainer.Size = new System.Drawing.Size(571, 537);
            this.splitContainer.SplitterDistance = 367;
            this.splitContainer.TabIndex = 0;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.LargeChange = 900;
            this.vScrollBar.Location = new System.Drawing.Point(554, 0);
            this.vScrollBar.Maximum = 1000;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 350);
            this.vScrollBar.TabIndex = 2;
            this.vScrollBar.Tag = "canvas";
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.LargeChange = 3500;
            this.hScrollBar.Location = new System.Drawing.Point(0, 350);
            this.hScrollBar.Maximum = 4000;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(571, 17);
            this.hScrollBar.TabIndex = 1;
            this.hScrollBar.Tag = "canvas";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(571, 367);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBoxInformation.Controls.Add(this.labelHowItWorks);
            this.groupBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInformation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(571, 166);
            this.groupBoxInformation.TabIndex = 14;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "User Guide (How It Works)";
            // 
            // labelHowItWorks
            // 
            this.labelHowItWorks.AutoSize = true;
            this.labelHowItWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowItWorks.Location = new System.Drawing.Point(18, 21);
            this.labelHowItWorks.Name = "labelHowItWorks";
            this.labelHowItWorks.Size = new System.Drawing.Size(0, 15);
            this.labelHowItWorks.TabIndex = 6;
            // 
            // labelOnlyInteger
            // 
            this.labelOnlyInteger.AutoSize = true;
            this.labelOnlyInteger.Location = new System.Drawing.Point(18, 9);
            this.labelOnlyInteger.Name = "labelOnlyInteger";
            this.labelOnlyInteger.Size = new System.Drawing.Size(0, 13);
            this.labelOnlyInteger.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataStructureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataStructureToolStripMenuItem
            // 
            this.dataStructureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.dataStructureToolStripMenuItem.Image = global::Data_Structure_Simulator.Properties.Resources.Home;
            this.dataStructureToolStripMenuItem.Name = "dataStructureToolStripMenuItem";
            this.dataStructureToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.dataStructureToolStripMenuItem.Text = "Data Structure";
            this.dataStructureToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Data_Structure_Simulator.Properties.Resources.newFile;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // dataStructureSimulator
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "dataStructureSimulator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOperationsStack.ResumeLayout(false);
            this.groupBoxOperationsTree.ResumeLayout(false);
            this.groupBoxOperationsLinkedList.ResumeLayout(false);
            this.groupBoxOperationsLinkedList.PerformLayout();
            this.groupBoxDataStructure.ResumeLayout(false);
            this.groupBoxDataStructure.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer;
        //........................ScrollBars.................................
        //.......................TAb Controls..................................
        //.......................Input GroupBox....................................
        private System.Windows.Forms.GroupBox groupBoxInput;
        public System.Windows.Forms.Label dataStructureUsed;
        private System.Windows.Forms.Label ShowDataStructureBeingUsed;
        private System.Windows.Forms.TextBox textBoxForInput;
        private System.Windows.Forms.Label labelNumberForInput;
        //............................DataStructure............................
        private System.Windows.Forms.GroupBox groupBoxDataStructure;
        private System.Windows.Forms.RadioButton radioButtonTree;
        private System.Windows.Forms.RadioButton radioButtonLinkedList;
        private System.Windows.Forms.RadioButton radioButtonStack;
        //..................................Setting Controls//...................................
        //....................................MenuStrip...............................................
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataStructureToolStripMenuItem;
        //............................. For Linked List.................................................... 

        private System.Windows.Forms.GroupBox groupBoxOperationsLinkedList;
        private System.Windows.Forms.Label labelAddAt;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton radioButtonAddAtEndLinkedList;
        private System.Windows.Forms.RadioButton radioButtonAddAtMiddleLinkedList;
        private System.Windows.Forms.RadioButton radioButtonAddAtStartLinkedList;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        //...........................For Stack.......................................
        private System.Windows.Forms.GroupBox groupBoxOperationsStack;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOperationsTree;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelOnlyInteger;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label countLable;
        private System.Windows.Forms.Label actionLable;
        private System.Windows.Forms.Label labelLastAction;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label labelTopsValue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label labelHowItWorks;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
    }
}

