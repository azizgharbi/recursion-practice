using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace Tree {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form {
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PlusMinusCB;
        private System.Windows.Forms.CheckBox LinesCB;
        private System.Windows.Forms.CheckBox RootLinesCB;
        private System.Windows.Forms.Button ApplyOptsBtn;
        private System.Windows.Forms.CheckBox CheckBoxesCB;
        private System.Windows.Forms.CheckBox LabelEditCB;
        private System.Windows.Forms.CheckBox HotTrackCB;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button ExpandAllBtn;
        private System.Windows.Forms.Button CollapseAllBtn;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem NewMI;
        private System.Windows.Forms.MenuItem ExitMI;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem IndexMI;
        private IContainer components;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node9", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tv = new System.Windows.Forms.TreeView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HotTrackCB = new System.Windows.Forms.CheckBox();
            this.LabelEditCB = new System.Windows.Forms.CheckBox();
            this.CheckBoxesCB = new System.Windows.Forms.CheckBox();
            this.ApplyOptsBtn = new System.Windows.Forms.Button();
            this.RootLinesCB = new System.Windows.Forms.CheckBox();
            this.LinesCB = new System.Windows.Forms.CheckBox();
            this.PlusMinusCB = new System.Windows.Forms.CheckBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ExpandAllBtn = new System.Windows.Forms.Button();
            this.CollapseAllBtn = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.NewMI = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.IndexMI = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.ExitMI = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.HideSelection = false;
            this.tv.Location = new System.Drawing.Point(56, 24);
            this.tv.Name = "tv";
            treeNode1.Name = "";
            treeNode1.Text = "Node5";
            treeNode2.Name = "";
            treeNode2.Text = "Node8";
            treeNode3.Name = "";
            treeNode3.Text = "Node4";
            treeNode4.Name = "";
            treeNode4.Text = "Node6";
            treeNode5.Name = "";
            treeNode5.Text = "Node1";
            treeNode6.Name = "";
            treeNode6.Text = "Node7";
            treeNode7.Name = "";
            treeNode7.Text = "Node2";
            treeNode8.Name = "";
            treeNode8.Text = "Node3";
            treeNode9.Name = "";
            treeNode9.Text = "Node0";
            treeNode10.Name = "";
            treeNode10.Text = "Node10";
            treeNode11.Name = "";
            treeNode11.Text = "Node9";
            this.tv.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11});
            this.tv.Size = new System.Drawing.Size(520, 368);
            this.tv.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(64, 408);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "&Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HotTrackCB);
            this.groupBox1.Controls.Add(this.LabelEditCB);
            this.groupBox1.Controls.Add(this.CheckBoxesCB);
            this.groupBox1.Controls.Add(this.ApplyOptsBtn);
            this.groupBox1.Controls.Add(this.RootLinesCB);
            this.groupBox1.Controls.Add(this.LinesCB);
            this.groupBox1.Controls.Add(this.PlusMinusCB);
            this.groupBox1.Location = new System.Drawing.Point(256, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Options ... ";
            // 
            // HotTrackCB
            // 
            this.HotTrackCB.Location = new System.Drawing.Point(160, 80);
            this.HotTrackCB.Name = "HotTrackCB";
            this.HotTrackCB.Size = new System.Drawing.Size(104, 24);
            this.HotTrackCB.TabIndex = 6;
            this.HotTrackCB.Text = "hot track";
            // 
            // LabelEditCB
            // 
            this.LabelEditCB.Location = new System.Drawing.Point(160, 48);
            this.LabelEditCB.Name = "LabelEditCB";
            this.LabelEditCB.Size = new System.Drawing.Size(104, 24);
            this.LabelEditCB.TabIndex = 5;
            this.LabelEditCB.Text = "edit labels";
            // 
            // CheckBoxesCB
            // 
            this.CheckBoxesCB.Location = new System.Drawing.Point(160, 16);
            this.CheckBoxesCB.Name = "CheckBoxesCB";
            this.CheckBoxesCB.Size = new System.Drawing.Size(168, 24);
            this.CheckBoxesCB.TabIndex = 4;
            this.CheckBoxesCB.Text = "show check boxes";
            // 
            // ApplyOptsBtn
            // 
            this.ApplyOptsBtn.Location = new System.Drawing.Point(304, 72);
            this.ApplyOptsBtn.Name = "ApplyOptsBtn";
            this.ApplyOptsBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyOptsBtn.TabIndex = 3;
            this.ApplyOptsBtn.Text = "Apply";
            this.ApplyOptsBtn.Click += new System.EventHandler(this.ApplyOptsBtn_Click);
            // 
            // RootLinesCB
            // 
            this.RootLinesCB.Location = new System.Drawing.Point(8, 80);
            this.RootLinesCB.Name = "RootLinesCB";
            this.RootLinesCB.Size = new System.Drawing.Size(104, 24);
            this.RootLinesCB.TabIndex = 2;
            this.RootLinesCB.Text = "show root lines";
            // 
            // LinesCB
            // 
            this.LinesCB.Location = new System.Drawing.Point(8, 48);
            this.LinesCB.Name = "LinesCB";
            this.LinesCB.Size = new System.Drawing.Size(104, 24);
            this.LinesCB.TabIndex = 1;
            this.LinesCB.Text = "show lines";
            // 
            // PlusMinusCB
            // 
            this.PlusMinusCB.Location = new System.Drawing.Point(8, 16);
            this.PlusMinusCB.Name = "PlusMinusCB";
            this.PlusMinusCB.Size = new System.Drawing.Size(136, 24);
            this.PlusMinusCB.TabIndex = 0;
            this.PlusMinusCB.Text = "show plus and minus";
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(64, 448);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 3;
            this.DelBtn.Text = "Delete";
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ExpandAllBtn
            // 
            this.ExpandAllBtn.Location = new System.Drawing.Point(168, 408);
            this.ExpandAllBtn.Name = "ExpandAllBtn";
            this.ExpandAllBtn.Size = new System.Drawing.Size(75, 23);
            this.ExpandAllBtn.TabIndex = 4;
            this.ExpandAllBtn.Text = "Expand All";
            this.ExpandAllBtn.Click += new System.EventHandler(this.ExpandAllBtn_Click);
            // 
            // CollapseAllBtn
            // 
            this.CollapseAllBtn.Location = new System.Drawing.Point(168, 448);
            this.CollapseAllBtn.Name = "CollapseAllBtn";
            this.CollapseAllBtn.Size = new System.Drawing.Size(75, 23);
            this.CollapseAllBtn.TabIndex = 5;
            this.CollapseAllBtn.Text = "Collapse All";
            this.CollapseAllBtn.Click += new System.EventHandler(this.CollapseAllBtn_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewMI,
            this.menuItem4,
            this.IndexMI,
            this.menuItem2,
            this.ExitMI});
            this.menuItem1.Text = "&File";
            // 
            // NewMI
            // 
            this.NewMI.Index = 0;
            this.NewMI.Text = "&New";
            this.NewMI.Click += new System.EventHandler(this.NewMI_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // IndexMI
            // 
            this.IndexMI.Index = 2;
            this.IndexMI.Text = "Index Tree";
            this.IndexMI.Click += new System.EventHandler(this.IndexMI_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // ExitMI
            // 
            this.ExitMI.Index = 4;
            this.ExitMI.Text = "&Exit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = ".";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.InitialDirectory = ".";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(672, 517);
            this.Controls.Add(this.CollapseAllBtn);
            this.Controls.Add(this.ExpandAllBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.tv);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new Form1());
        }



        private void ApplyOptsBtn_Click(object sender, System.EventArgs e) {
            tv.ShowPlusMinus = PlusMinusCB.Checked;
            tv.ShowLines = LinesCB.Checked;
            tv.ShowRootLines = RootLinesCB.Checked;
            tv.CheckBoxes = CheckBoxesCB.Checked;
            tv.LabelEdit = LabelEditCB.Checked;
            tv.HotTracking = HotTrackCB.Checked;
        }

        private void AddNode() {
            TreeNode newNode = new TreeNode("[New Node]");
            TreeNode selNode = tv.SelectedNode;

            if (selNode != null) {
                selNode.Nodes.Add(newNode);
                tv.SelectedNode.Expand();
            } else {
                tv.Nodes.Add(newNode);
                tv.SelectedNode = newNode;
            }
        }

        private void AddBtn_Click(object sender, System.EventArgs e) {
            AddNode();
        }

        private void DelBtn_Click(object sender, System.EventArgs e) {
            TreeNode selNode = tv.SelectedNode;
            DialogResult result;

            if (selNode != null) {
                if (selNode.Nodes.Count > 0) {
                    result = MessageBox.Show(
                        "There are branches beneath this node. Delete all?",
                        "Warning!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        tv.SelectedNode.Remove();
                } else tv.SelectedNode.Remove();

            }
        }

        private void ExpandAllBtn_Click(object sender, System.EventArgs e) {
            tv.ExpandAll();
        }

        private void CollapseAllBtn_Click(object sender, System.EventArgs e) {
            tv.CollapseAll();
        }

        private void NewMI_Click(object sender, System.EventArgs e) {
            tv.Nodes.Clear();
        }


        String s = "";
        int NodeIndex = 0;

        private void TraverseNodes(TreeNode treeNode, int NodeLevel) {

            s += treeNode.Text + " [" + NodeIndex + "] at Level " + NodeLevel + '\n';
            NodeIndex++;
            NodeLevel++;
            foreach (TreeNode tn in treeNode.Nodes) {
                TraverseNodes(tn, NodeLevel);
            }
        }

        private void IndexMI_Click(object sender, System.EventArgs e) {
            s = "";
            NodeIndex = 0;
            foreach (TreeNode n in tv.Nodes) {
                TraverseNodes(n, 0);
            }
            MessageBox.Show(s);
        }
    }
}


