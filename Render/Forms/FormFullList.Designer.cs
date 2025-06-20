namespace Course.Render.Forms
{
    partial class FormFullList
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
            flowLayoutElements = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutElements
            // 
            flowLayoutElements.AutoScroll = true;
            flowLayoutElements.Dock = DockStyle.Fill;
            flowLayoutElements.Location = new Point(0, 0);
            flowLayoutElements.Name = "flowLayoutElements";
            flowLayoutElements.Size = new Size(800, 597);
            flowLayoutElements.TabIndex = 1;
            // 
            // FormFullList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(flowLayoutElements);
            Name = "FormFullList";
            Text = "Всі елементи";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutElements;
    }
}