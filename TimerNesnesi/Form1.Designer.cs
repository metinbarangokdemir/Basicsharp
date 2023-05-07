namespace TimerNesnesi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node18", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node17", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node16", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node15", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Küçükçekmece", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Kadıköy");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bayrampaşa");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("İstanbul", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Ulus");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Çankaya");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Kızılay");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ankara", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Ziyapaşa");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Yüreğir");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Ceyhan");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Adana", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(267, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node19";
            treeNode1.Text = "Node19";
            treeNode2.Name = "Node18";
            treeNode2.Text = "Node18";
            treeNode3.Name = "Node17";
            treeNode3.Text = "Node17";
            treeNode4.Name = "Node16";
            treeNode4.Text = "Node16";
            treeNode5.Name = "Node15";
            treeNode5.Text = "Node15";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Küçükçekmece";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Kadıköy";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Bayrampaşa";
            treeNode9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode9.ForeColor = System.Drawing.Color.Red;
            treeNode9.Name = "Node0";
            treeNode9.Text = "İstanbul";
            treeNode10.Name = "Node9";
            treeNode10.Text = "Ulus";
            treeNode11.Name = "Node10";
            treeNode11.Text = "Çankaya";
            treeNode12.Name = "Node11";
            treeNode12.Text = "Kızılay";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Ankara";
            treeNode14.Name = "Node12";
            treeNode14.Text = "Ziyapaşa";
            treeNode15.Name = "Node13";
            treeNode15.Text = "Yüreğir";
            treeNode16.Name = "Node14";
            treeNode16.Text = "Ceyhan";
            treeNode17.Name = "Node2";
            treeNode17.Text = "Adana";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode13,
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(274, 380);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

