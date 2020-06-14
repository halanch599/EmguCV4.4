namespace EmgucvDemo
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRegionOfROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyEdgesROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiScaleTemplateMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFMatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fLANNMatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harrisDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiTomasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fASTDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRBDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSERDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findContoursSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filledObjectDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectObjectsWithHolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countHolesİnObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEqualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLAHEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backpropagationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.processToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Open";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processROIToolStripMenuItem,
            this.templateMatchingToolStripMenuItem,
            this.featureMatchingToolStripMenuItem,
            this.featureDetectorToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.processToolStripMenuItem.Text = "Feature 2D";
            // 
            // processROIToolStripMenuItem
            // 
            this.processROIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectROIToolStripMenuItem,
            this.getRegionOfROIToolStripMenuItem,
            this.gaussianBlurROIToolStripMenuItem,
            this.cannyEdgesROIToolStripMenuItem});
            this.processROIToolStripMenuItem.Name = "processROIToolStripMenuItem";
            this.processROIToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.processROIToolStripMenuItem.Text = "Process ROI";
            // 
            // selectROIToolStripMenuItem
            // 
            this.selectROIToolStripMenuItem.Name = "selectROIToolStripMenuItem";
            this.selectROIToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.selectROIToolStripMenuItem.Text = "Select ROI";
            this.selectROIToolStripMenuItem.Click += new System.EventHandler(this.selectROIToolStripMenuItem_Click);
            // 
            // getRegionOfROIToolStripMenuItem
            // 
            this.getRegionOfROIToolStripMenuItem.Name = "getRegionOfROIToolStripMenuItem";
            this.getRegionOfROIToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.getRegionOfROIToolStripMenuItem.Text = "Get Region of ROI";
            this.getRegionOfROIToolStripMenuItem.Click += new System.EventHandler(this.getRegionOfROIToolStripMenuItem_Click);
            // 
            // gaussianBlurROIToolStripMenuItem
            // 
            this.gaussianBlurROIToolStripMenuItem.Name = "gaussianBlurROIToolStripMenuItem";
            this.gaussianBlurROIToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.gaussianBlurROIToolStripMenuItem.Text = "Gaussian Blur ROI";
            this.gaussianBlurROIToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurROIToolStripMenuItem_Click);
            // 
            // cannyEdgesROIToolStripMenuItem
            // 
            this.cannyEdgesROIToolStripMenuItem.Name = "cannyEdgesROIToolStripMenuItem";
            this.cannyEdgesROIToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.cannyEdgesROIToolStripMenuItem.Text = "Canny Edges ROI";
            this.cannyEdgesROIToolStripMenuItem.Click += new System.EventHandler(this.cannyEdgesROIToolStripMenuItem_Click);
            // 
            // templateMatchingToolStripMenuItem
            // 
            this.templateMatchingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchingToolStripMenuItem,
            this.multiScaleTemplateMatchingToolStripMenuItem,
            this.multiToolStripMenuItem});
            this.templateMatchingToolStripMenuItem.Name = "templateMatchingToolStripMenuItem";
            this.templateMatchingToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.templateMatchingToolStripMenuItem.Text = "Template Matching";
            // 
            // matchingToolStripMenuItem
            // 
            this.matchingToolStripMenuItem.Name = "matchingToolStripMenuItem";
            this.matchingToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.matchingToolStripMenuItem.Text = "Matching";
            this.matchingToolStripMenuItem.Click += new System.EventHandler(this.matchingToolStripMenuItem_Click);
            // 
            // multiScaleTemplateMatchingToolStripMenuItem
            // 
            this.multiScaleTemplateMatchingToolStripMenuItem.Name = "multiScaleTemplateMatchingToolStripMenuItem";
            this.multiScaleTemplateMatchingToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.multiScaleTemplateMatchingToolStripMenuItem.Text = "Multi-Scale Template Matching";
            this.multiScaleTemplateMatchingToolStripMenuItem.Click += new System.EventHandler(this.multiScaleTemplateMatchingToolStripMenuItem_Click);
            // 
            // multiToolStripMenuItem
            // 
            this.multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            this.multiToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.multiToolStripMenuItem.Text = "Multi Object Detection";
            this.multiToolStripMenuItem.Click += new System.EventHandler(this.multiToolStripMenuItem_Click);
            // 
            // featureMatchingToolStripMenuItem
            // 
            this.featureMatchingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bFMatcherToolStripMenuItem,
            this.fLANNMatcherToolStripMenuItem});
            this.featureMatchingToolStripMenuItem.Name = "featureMatchingToolStripMenuItem";
            this.featureMatchingToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.featureMatchingToolStripMenuItem.Text = "Feature Matching";
            this.featureMatchingToolStripMenuItem.Click += new System.EventHandler(this.featureMatchingToolStripMenuItem_Click);
            // 
            // bFMatcherToolStripMenuItem
            // 
            this.bFMatcherToolStripMenuItem.Name = "bFMatcherToolStripMenuItem";
            this.bFMatcherToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.bFMatcherToolStripMenuItem.Text = "Brute Force Matcher";
            this.bFMatcherToolStripMenuItem.Click += new System.EventHandler(this.bFMatcherToolStripMenuItem_Click);
            // 
            // fLANNMatcherToolStripMenuItem
            // 
            this.fLANNMatcherToolStripMenuItem.Name = "fLANNMatcherToolStripMenuItem";
            this.fLANNMatcherToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.fLANNMatcherToolStripMenuItem.Text = "FLANN Matcher";
            this.fLANNMatcherToolStripMenuItem.Click += new System.EventHandler(this.fLANNMatcherToolStripMenuItem_Click);
            // 
            // featureDetectorToolStripMenuItem
            // 
            this.featureDetectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harrisDetectorToolStripMenuItem,
            this.shiTomasiToolStripMenuItem,
            this.fASTDetectorToolStripMenuItem,
            this.oRBDetectorToolStripMenuItem,
            this.mSERDetectorToolStripMenuItem});
            this.featureDetectorToolStripMenuItem.Name = "featureDetectorToolStripMenuItem";
            this.featureDetectorToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.featureDetectorToolStripMenuItem.Text = "Feature Detector";
            // 
            // harrisDetectorToolStripMenuItem
            // 
            this.harrisDetectorToolStripMenuItem.Name = "harrisDetectorToolStripMenuItem";
            this.harrisDetectorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.harrisDetectorToolStripMenuItem.Text = "Harris Detector";
            this.harrisDetectorToolStripMenuItem.Click += new System.EventHandler(this.harrisDetectorToolStripMenuItem_Click);
            // 
            // shiTomasiToolStripMenuItem
            // 
            this.shiTomasiToolStripMenuItem.Name = "shiTomasiToolStripMenuItem";
            this.shiTomasiToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.shiTomasiToolStripMenuItem.Text = "Shi-Tomasi";
            this.shiTomasiToolStripMenuItem.Click += new System.EventHandler(this.shiTomasiToolStripMenuItem_Click);
            // 
            // fASTDetectorToolStripMenuItem
            // 
            this.fASTDetectorToolStripMenuItem.Name = "fASTDetectorToolStripMenuItem";
            this.fASTDetectorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.fASTDetectorToolStripMenuItem.Text = "FAST Detector";
            this.fASTDetectorToolStripMenuItem.Click += new System.EventHandler(this.fASTDetectorToolStripMenuItem_Click);
            // 
            // oRBDetectorToolStripMenuItem
            // 
            this.oRBDetectorToolStripMenuItem.Name = "oRBDetectorToolStripMenuItem";
            this.oRBDetectorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.oRBDetectorToolStripMenuItem.Text = "ORB Detector";
            this.oRBDetectorToolStripMenuItem.Click += new System.EventHandler(this.oRBDetectorToolStripMenuItem_Click);
            // 
            // mSERDetectorToolStripMenuItem
            // 
            this.mSERDetectorToolStripMenuItem.Name = "mSERDetectorToolStripMenuItem";
            this.mSERDetectorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.mSERDetectorToolStripMenuItem.Text = "MSER Detector";
            this.mSERDetectorToolStripMenuItem.Click += new System.EventHandler(this.mSERDetectorToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformationsToolStripMenuItem,
            this.binarizeToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // transformationsToolStripMenuItem
            // 
            this.transformationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.rotationToolStripMenuItem});
            this.transformationsToolStripMenuItem.Name = "transformationsToolStripMenuItem";
            this.transformationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transformationsToolStripMenuItem.Text = "Transformations";
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.rotationToolStripMenuItem.Text = "Rotation";
            this.rotationToolStripMenuItem.Click += new System.EventHandler(this.rotationToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem1
            // 
            this.processToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findContoursSortToolStripMenuItem,
            this.objectDetectionToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.processToolStripMenuItem1.Name = "processToolStripMenuItem1";
            this.processToolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.processToolStripMenuItem1.Text = "Process";
            // 
            // findContoursSortToolStripMenuItem
            // 
            this.findContoursSortToolStripMenuItem.Name = "findContoursSortToolStripMenuItem";
            this.findContoursSortToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.findContoursSortToolStripMenuItem.Text = "Find Contours && Sort";
            this.findContoursSortToolStripMenuItem.Click += new System.EventHandler(this.findContoursSortToolStripMenuItem_Click);
            // 
            // objectDetectionToolStripMenuItem
            // 
            this.objectDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorBasedToolStripMenuItem,
            this.filledObjectDetectionToolStripMenuItem,
            this.detectObjectsWithHolesToolStripMenuItem,
            this.countHolesİnObjectToolStripMenuItem});
            this.objectDetectionToolStripMenuItem.Name = "objectDetectionToolStripMenuItem";
            this.objectDetectionToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.objectDetectionToolStripMenuItem.Text = "Object Detection";
            // 
            // colorBasedToolStripMenuItem
            // 
            this.colorBasedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.redToolStripMenuItem});
            this.colorBasedToolStripMenuItem.Name = "colorBasedToolStripMenuItem";
            this.colorBasedToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.colorBasedToolStripMenuItem.Text = "Color-Based";
            this.colorBasedToolStripMenuItem.Click += new System.EventHandler(this.colorBasedToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // filledObjectDetectionToolStripMenuItem
            // 
            this.filledObjectDetectionToolStripMenuItem.Name = "filledObjectDetectionToolStripMenuItem";
            this.filledObjectDetectionToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.filledObjectDetectionToolStripMenuItem.Text = "Filled Object Detection";
            this.filledObjectDetectionToolStripMenuItem.Click += new System.EventHandler(this.filledObjectDetectionToolStripMenuItem_Click);
            // 
            // detectObjectsWithHolesToolStripMenuItem
            // 
            this.detectObjectsWithHolesToolStripMenuItem.Name = "detectObjectsWithHolesToolStripMenuItem";
            this.detectObjectsWithHolesToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.detectObjectsWithHolesToolStripMenuItem.Text = "Detect Objects with Holes";
            this.detectObjectsWithHolesToolStripMenuItem.Click += new System.EventHandler(this.detectObjectsWithHolesToolStripMenuItem_Click);
            // 
            // countHolesİnObjectToolStripMenuItem
            // 
            this.countHolesİnObjectToolStripMenuItem.Name = "countHolesİnObjectToolStripMenuItem";
            this.countHolesİnObjectToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.countHolesİnObjectToolStripMenuItem.Text = "Count Holes in Object";
            this.countHolesİnObjectToolStripMenuItem.Click += new System.EventHandler(this.countHolesİnObjectToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 610);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 604);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Location = new System.Drawing.Point(4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 373);
            this.panel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 373);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(214, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 604);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 604);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.histogramEqualizationToolStripMenuItem,
            this.cLAHEToolStripMenuItem,
            this.backpropagationToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click_1);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            this.binarizeToolStripMenuItem.Click += new System.EventHandler(this.binarizeToolStripMenuItem_Click);
            // 
            // histogramEqualizationToolStripMenuItem
            // 
            this.histogramEqualizationToolStripMenuItem.Name = "histogramEqualizationToolStripMenuItem";
            this.histogramEqualizationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.histogramEqualizationToolStripMenuItem.Text = "Histogram Equalization";
            this.histogramEqualizationToolStripMenuItem.Click += new System.EventHandler(this.histogramEqualizationToolStripMenuItem_Click);
            // 
            // cLAHEToolStripMenuItem
            // 
            this.cLAHEToolStripMenuItem.Name = "cLAHEToolStripMenuItem";
            this.cLAHEToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.cLAHEToolStripMenuItem.Text = "CLAHE";
            this.cLAHEToolStripMenuItem.Click += new System.EventHandler(this.cLAHEToolStripMenuItem_Click);
            // 
            // backpropagationToolStripMenuItem
            // 
            this.backpropagationToolStripMenuItem.Name = "backpropagationToolStripMenuItem";
            this.backpropagationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.backpropagationToolStripMenuItem.Text = "Backpropagation";
            this.backpropagationToolStripMenuItem.Click += new System.EventHandler(this.backpropagationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectROIToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem getRegionOfROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyEdgesROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiScaleTemplateMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFMatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fLANNMatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harrisDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiTomasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fASTDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRBDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSERDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findContoursSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filledObjectDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectObjectsWithHolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countHolesİnObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEqualizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLAHEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backpropagationToolStripMenuItem;
    }
}

