namespace Comp01_TextEdit
{
    partial class TextEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEdit));
            this.richTextbox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonNew = new System.Windows.Forms.ToolStripButton();
            this.buttonOpen = new System.Windows.Forms.ToolStripButton();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.dropdownPlugins = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstripitemNoPlugins = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextbox
            // 
            this.richTextbox.Location = new System.Drawing.Point(0, 28);
            this.richTextbox.Name = "richTextbox";
            this.richTextbox.Size = new System.Drawing.Size(800, 421);
            this.richTextbox.TabIndex = 0;
            this.richTextbox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNew,
            this.buttonOpen,
            this.buttonSave,
            this.dropdownPlugins});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonNew
            // 
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 22);
            this.buttonNew.Text = "New file";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 22);
            this.buttonOpen.Text = "Open file";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 22);
            this.buttonSave.Text = "Save file";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dropdownPlugins
            // 
            this.dropdownPlugins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripitemNoPlugins});
            this.dropdownPlugins.Image = ((System.Drawing.Image)(resources.GetObject("dropdownPlugins.Image")));
            this.dropdownPlugins.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownPlugins.Name = "dropdownPlugins";
            this.dropdownPlugins.Size = new System.Drawing.Size(94, 22);
            this.dropdownPlugins.Text = "Run plugin";
            // 
            // toolstripitemNoPlugins
            // 
            this.toolstripitemNoPlugins.Name = "toolstripitemNoPlugins";
            this.toolstripitemNoPlugins.Size = new System.Drawing.Size(185, 22);
            this.toolstripitemNoPlugins.Text = "(no plugins installed)";
            // 
            // TextEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextbox);
            this.Name = "TextEdit";
            this.Text = "TextEdit (K. Niedzwiecki 45575)";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextbox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonNew;
        private System.Windows.Forms.ToolStripButton buttonOpen;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ToolStripDropDownButton dropdownPlugins;
        private System.Windows.Forms.ToolStripMenuItem toolstripitemNoPlugins;
    }
}

