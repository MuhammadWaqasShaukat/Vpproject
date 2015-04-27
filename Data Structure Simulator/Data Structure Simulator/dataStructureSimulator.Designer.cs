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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.ShowDataStructureBeingUsed = new System.Windows.Forms.Label();
            this.textBoxForInput = new System.Windows.Forms.TextBox();
            this.dataStructureUsed = new System.Windows.Forms.Label();
            this.labelNumberForInput = new System.Windows.Forms.Label();
            this.groupBoxOptionsTree = new System.Windows.Forms.GroupBox();
            this.labelTreeNodes = new System.Windows.Forms.Label();
            this.labelNode = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.groupBoxOptionsLinkedList = new System.Windows.Forms.GroupBox();
            this.labelAddAfter = new System.Windows.Forms.Label();
            this.labelAddAt = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxAddAfter = new System.Windows.Forms.TextBox();
            this.radioButtonAddAtEnd = new System.Windows.Forms.RadioButton();
            this.radioButtonAddAtMiddle = new System.Windows.Forms.RadioButton();
            this.radioButtonAddAtStart = new System.Windows.Forms.RadioButton();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxOptionsStack = new System.Windows.Forms.GroupBox();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.topValue = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.groupBoxDataStructure = new System.Windows.Forms.GroupBox();
            this.radioButtonTree = new System.Windows.Forms.RadioButton();
            this.radioButtonLinkedList = new System.Windows.Forms.RadioButton();
            this.radioButtonStack = new System.Windows.Forms.RadioButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControlDsSimulator = new System.Windows.Forms.TabControl();
            this.tabPageSimulation = new System.Windows.Forms.TabPage();
            this.hScrollBarSimulator = new System.Windows.Forms.HScrollBar();
            this.vScrollBarSimulator = new System.Windows.Forms.VScrollBar();
            this.tabPageCodeView = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOptionsTree.SuspendLayout();
            this.groupBoxOptionsLinkedList.SuspendLayout();
            this.groupBoxOptionsStack.SuspendLayout();
            this.groupBoxDataStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControlDsSimulator.SuspendLayout();
            this.tabPageSimulation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxInput);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOptionsTree);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOptionsLinkedList);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOptionsStack);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxDataStructure);
            this.splitContainer2.Panel1.Margin = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer);
            this.splitContainer2.Size = new System.Drawing.Size(584, 437);
            this.splitContainer2.SplitterDistance = 205;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.ShowDataStructureBeingUsed);
            this.groupBoxInput.Controls.Add(this.textBoxForInput);
            this.groupBoxInput.Controls.Add(this.dataStructureUsed);
            this.groupBoxInput.Controls.Add(this.labelNumberForInput);
            this.groupBoxInput.Location = new System.Drawing.Point(6, 6);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(192, 97);
            this.groupBoxInput.TabIndex = 13;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            this.groupBoxInput.Visible = false;
            // 
            // ShowDataStructureBeingUsed
            // 
            this.ShowDataStructureBeingUsed.AutoSize = true;
            this.ShowDataStructureBeingUsed.Location = new System.Drawing.Point(9, 32);
            this.ShowDataStructureBeingUsed.Name = "ShowDataStructureBeingUsed";
            this.ShowDataStructureBeingUsed.Size = new System.Drawing.Size(79, 13);
            this.ShowDataStructureBeingUsed.TabIndex = 0;
            this.ShowDataStructureBeingUsed.Text = "Data Structure:";
            // 
            // textBoxForInput
            // 
            this.textBoxForInput.Location = new System.Drawing.Point(65, 55);
            this.textBoxForInput.Name = "textBoxForInput";
            this.textBoxForInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxForInput.TabIndex = 12;
            this.textBoxForInput.TextChanged += new System.EventHandler(this.textBoxForInput_TextChanged);
            // 
            // dataStructureUsed
            // 
            this.dataStructureUsed.AutoSize = true;
            this.dataStructureUsed.Location = new System.Drawing.Point(102, 32);
            this.dataStructureUsed.Name = "dataStructureUsed";
            this.dataStructureUsed.Size = new System.Drawing.Size(0, 13);
            this.dataStructureUsed.TabIndex = 1;
            // 
            // labelNumberForInput
            // 
            this.labelNumberForInput.AutoSize = true;
            this.labelNumberForInput.Location = new System.Drawing.Point(12, 58);
            this.labelNumberForInput.Name = "labelNumberForInput";
            this.labelNumberForInput.Size = new System.Drawing.Size(47, 13);
            this.labelNumberForInput.TabIndex = 11;
            this.labelNumberForInput.Text = "Number:";
            // 
            // groupBoxOptionsTree
            // 
            this.groupBoxOptionsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptionsTree.Controls.Add(this.labelTreeNodes);
            this.groupBoxOptionsTree.Controls.Add(this.labelNode);
            this.groupBoxOptionsTree.Controls.Add(this.buttonDelete);
            this.groupBoxOptionsTree.Controls.Add(this.buttonFind);
            this.groupBoxOptionsTree.Controls.Add(this.buttonInsert);
            this.groupBoxOptionsTree.Location = new System.Drawing.Point(6, 115);
            this.groupBoxOptionsTree.Name = "groupBoxOptionsTree";
            this.groupBoxOptionsTree.Size = new System.Drawing.Size(193, 100);
            this.groupBoxOptionsTree.TabIndex = 0;
            this.groupBoxOptionsTree.TabStop = false;
            this.groupBoxOptionsTree.Text = "Options";
            this.groupBoxOptionsTree.Visible = false;
            // 
            // labelTreeNodes
            // 
            this.labelTreeNodes.AutoSize = true;
            this.labelTreeNodes.Location = new System.Drawing.Point(57, 20);
            this.labelTreeNodes.Name = "labelTreeNodes";
            this.labelTreeNodes.Size = new System.Drawing.Size(0, 13);
            this.labelTreeNodes.TabIndex = 4;
            // 
            // labelNode
            // 
            this.labelNode.AutoSize = true;
            this.labelNode.Location = new System.Drawing.Point(15, 20);
            this.labelNode.Name = "labelNode";
            this.labelNode.Size = new System.Drawing.Size(47, 13);
            this.labelNode.TabIndex = 3;
            this.labelNode.Text = "Nodes : ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(121, 48);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(47, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(68, 48);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(47, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(15, 48);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(47, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // groupBoxOptionsLinkedList
            // 
            this.groupBoxOptionsLinkedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptionsLinkedList.Controls.Add(this.labelAddAfter);
            this.groupBoxOptionsLinkedList.Controls.Add(this.labelAddAt);
            this.groupBoxOptionsLinkedList.Controls.Add(this.buttonSearch);
            this.groupBoxOptionsLinkedList.Controls.Add(this.textBoxAddAfter);
            this.groupBoxOptionsLinkedList.Controls.Add(this.radioButtonAddAtEnd);
            this.groupBoxOptionsLinkedList.Controls.Add(this.radioButtonAddAtMiddle);
            this.groupBoxOptionsLinkedList.Controls.Add(this.radioButtonAddAtStart);
            this.groupBoxOptionsLinkedList.Controls.Add(this.buttonRemove);
            this.groupBoxOptionsLinkedList.Controls.Add(this.buttonAdd);
            this.groupBoxOptionsLinkedList.Location = new System.Drawing.Point(6, 115);
            this.groupBoxOptionsLinkedList.Name = "groupBoxOptionsLinkedList";
            this.groupBoxOptionsLinkedList.Size = new System.Drawing.Size(193, 163);
            this.groupBoxOptionsLinkedList.TabIndex = 4;
            this.groupBoxOptionsLinkedList.TabStop = false;
            this.groupBoxOptionsLinkedList.Text = "Options";
            this.groupBoxOptionsLinkedList.Visible = false;
            // 
            // labelAddAfter
            // 
            this.labelAddAfter.AutoSize = true;
            this.labelAddAfter.Location = new System.Drawing.Point(13, 135);
            this.labelAddAfter.Name = "labelAddAfter";
            this.labelAddAfter.Size = new System.Drawing.Size(57, 13);
            this.labelAddAfter.TabIndex = 8;
            this.labelAddAfter.Text = "Add After :";
            // 
            // labelAddAt
            // 
            this.labelAddAt.AutoSize = true;
            this.labelAddAt.Location = new System.Drawing.Point(7, 71);
            this.labelAddAt.Name = "labelAddAt";
            this.labelAddAt.Size = new System.Drawing.Size(45, 13);
            this.labelAddAt.TabIndex = 7;
            this.labelAddAt.Text = "Add At :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(59, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(58, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxAddAfter
            // 
            this.textBoxAddAfter.Location = new System.Drawing.Point(76, 132);
            this.textBoxAddAfter.Name = "textBoxAddAfter";
            this.textBoxAddAfter.Size = new System.Drawing.Size(76, 20);
            this.textBoxAddAfter.TabIndex = 5;
            // 
            // radioButtonAddAtEnd
            // 
            this.radioButtonAddAtEnd.AutoSize = true;
            this.radioButtonAddAtEnd.Location = new System.Drawing.Point(133, 96);
            this.radioButtonAddAtEnd.Name = "radioButtonAddAtEnd";
            this.radioButtonAddAtEnd.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAddAtEnd.TabIndex = 4;
            this.radioButtonAddAtEnd.TabStop = true;
            this.radioButtonAddAtEnd.Text = "End";
            this.radioButtonAddAtEnd.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddAtMiddle
            // 
            this.radioButtonAddAtMiddle.AutoSize = true;
            this.radioButtonAddAtMiddle.Location = new System.Drawing.Point(78, 96);
            this.radioButtonAddAtMiddle.Name = "radioButtonAddAtMiddle";
            this.radioButtonAddAtMiddle.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAddAtMiddle.TabIndex = 3;
            this.radioButtonAddAtMiddle.TabStop = true;
            this.radioButtonAddAtMiddle.Text = "Middle";
            this.radioButtonAddAtMiddle.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddAtStart
            // 
            this.radioButtonAddAtStart.AutoSize = true;
            this.radioButtonAddAtStart.Location = new System.Drawing.Point(23, 96);
            this.radioButtonAddAtStart.Name = "radioButtonAddAtStart";
            this.radioButtonAddAtStart.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAddAtStart.TabIndex = 2;
            this.radioButtonAddAtStart.TabStop = true;
            this.radioButtonAddAtStart.Text = "Start";
            this.radioButtonAddAtStart.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(117, 33);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(59, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxOptionsStack
            // 
            this.groupBoxOptionsStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptionsStack.Controls.Add(this.buttonPop);
            this.groupBoxOptionsStack.Controls.Add(this.buttonPush);
            this.groupBoxOptionsStack.Controls.Add(this.topValue);
            this.groupBoxOptionsStack.Controls.Add(this.labelTop);
            this.groupBoxOptionsStack.Location = new System.Drawing.Point(6, 115);
            this.groupBoxOptionsStack.Name = "groupBoxOptionsStack";
            this.groupBoxOptionsStack.Size = new System.Drawing.Size(192, 94);
            this.groupBoxOptionsStack.TabIndex = 13;
            this.groupBoxOptionsStack.TabStop = false;
            this.groupBoxOptionsStack.Text = "Options";
            this.groupBoxOptionsStack.Visible = false;
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(87, 48);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(75, 27);
            this.buttonPop.TabIndex = 3;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            // 
            // buttonPush
            // 
            this.buttonPush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPush.Location = new System.Drawing.Point(10, 48);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(75, 27);
            this.buttonPush.TabIndex = 2;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            // 
            // topValue
            // 
            this.topValue.AutoSize = true;
            this.topValue.Location = new System.Drawing.Point(48, 20);
            this.topValue.Name = "topValue";
            this.topValue.Size = new System.Drawing.Size(0, 13);
            this.topValue.TabIndex = 1;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(7, 20);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(32, 13);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Top :";
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
            this.groupBoxDataStructure.Size = new System.Drawing.Size(193, 90);
            this.groupBoxDataStructure.TabIndex = 0;
            this.groupBoxDataStructure.TabStop = false;
            this.groupBoxDataStructure.Text = "Data Structure";
            this.groupBoxDataStructure.Visible = false;
            this.groupBoxDataStructure.Enter += new System.EventHandler(this.groupBoxDataStructure_Enter);
            // 
            // radioButtonTree
            // 
            this.radioButtonTree.AutoSize = true;
            this.radioButtonTree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonTree.Location = new System.Drawing.Point(30, 65);
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
            this.radioButtonLinkedList.Location = new System.Drawing.Point(30, 42);
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
            this.radioButtonStack.Location = new System.Drawing.Point(30, 20);
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
            this.splitContainer.Panel1.Controls.Add(this.tabControlDsSimulator);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer.Size = new System.Drawing.Size(375, 437);
            this.splitContainer.SplitterDistance = 306;
            this.splitContainer.TabIndex = 0;
            // 
            // tabControlDsSimulator
            // 
            this.tabControlDsSimulator.Controls.Add(this.tabPageSimulation);
            this.tabControlDsSimulator.Controls.Add(this.tabPageCodeView);
            this.tabControlDsSimulator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDsSimulator.Location = new System.Drawing.Point(0, 0);
            this.tabControlDsSimulator.Name = "tabControlDsSimulator";
            this.tabControlDsSimulator.SelectedIndex = 0;
            this.tabControlDsSimulator.Size = new System.Drawing.Size(375, 306);
            this.tabControlDsSimulator.TabIndex = 2;
            // 
            // tabPageSimulation
            // 
            this.tabPageSimulation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageSimulation.Controls.Add(this.hScrollBarSimulator);
            this.tabPageSimulation.Controls.Add(this.vScrollBarSimulator);
            this.tabPageSimulation.Location = new System.Drawing.Point(4, 22);
            this.tabPageSimulation.Name = "tabPageSimulation";
            this.tabPageSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSimulation.Size = new System.Drawing.Size(367, 280);
            this.tabPageSimulation.TabIndex = 0;
            this.tabPageSimulation.Text = "Simulation";
            this.tabPageSimulation.ToolTipText = "View The Graphics Representaion Of The Selected Data Structure ";
            this.tabPageSimulation.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageSimulation_Paint);
            // 
            // hScrollBarSimulator
            // 
            this.hScrollBarSimulator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBarSimulator.Location = new System.Drawing.Point(3, 260);
            this.hScrollBarSimulator.Name = "hScrollBarSimulator";
            this.hScrollBarSimulator.Size = new System.Drawing.Size(347, 17);
            this.hScrollBarSimulator.TabIndex = 1;
            // 
            // vScrollBarSimulator
            // 
            this.vScrollBarSimulator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBarSimulator.Location = new System.Drawing.Point(350, -1);
            this.vScrollBarSimulator.Name = "vScrollBarSimulator";
            this.vScrollBarSimulator.Size = new System.Drawing.Size(17, 278);
            this.vScrollBarSimulator.TabIndex = 0;
            // 
            // tabPageCodeView
            // 
            this.tabPageCodeView.Location = new System.Drawing.Point(4, 22);
            this.tabPageCodeView.Name = "tabPageCodeView";
            this.tabPageCodeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCodeView.Size = new System.Drawing.Size(367, 280);
            this.tabPageCodeView.TabIndex = 1;
            this.tabPageCodeView.Text = "Code";
            this.tabPageCodeView.ToolTipText = "view the code of data structure selected";
            this.tabPageCodeView.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataStructureToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataStructureToolStripMenuItem
            // 
            this.dataStructureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.dataStructureToolStripMenuItem.Name = "dataStructureToolStripMenuItem";
            this.dataStructureToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.dataStructureToolStripMenuItem.Text = "Data Structure";
            this.dataStructureToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // dataStructureSimulator
            // 
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "dataStructureSimulator";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOptionsTree.ResumeLayout(false);
            this.groupBoxOptionsTree.PerformLayout();
            this.groupBoxOptionsLinkedList.ResumeLayout(false);
            this.groupBoxOptionsLinkedList.PerformLayout();
            this.groupBoxOptionsStack.ResumeLayout(false);
            this.groupBoxOptionsStack.PerformLayout();
            this.groupBoxDataStructure.ResumeLayout(false);
            this.groupBoxDataStructure.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControlDsSimulator.ResumeLayout(false);
            this.tabPageSimulation.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer;
        //........................ScrollBars.................................
        private System.Windows.Forms.HScrollBar hScrollBarSimulator;
        //.......................TAb Controls..................................
        private System.Windows.Forms.TabControl tabControlDsSimulator;
        private System.Windows.Forms.TabPage tabPageCodeView;
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
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        //............................. For Linked List.................................................... 
        
        private System.Windows.Forms.GroupBox groupBoxOptionsLinkedList;
        private System.Windows.Forms.Label labelAddAfter;
        private System.Windows.Forms.Label labelAddAt;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxAddAfter;
        private System.Windows.Forms.RadioButton radioButtonAddAtEnd;
        private System.Windows.Forms.RadioButton radioButtonAddAtMiddle;
        private System.Windows.Forms.RadioButton radioButtonAddAtStart;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        //...........................For Stack.......................................
        private System.Windows.Forms.GroupBox groupBoxOptionsStack;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Label topValue;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOptionsTree;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelTreeNodes;
        private System.Windows.Forms.Label labelNode;
        public System.Windows.Forms.TabPage tabPageSimulation;
        private System.Windows.Forms.VScrollBar vScrollBarSimulator;
    }
}

