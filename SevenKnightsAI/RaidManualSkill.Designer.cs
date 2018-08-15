namespace SevenKnightsAI
{

    public partial class RaidManualSkill : global::System.Windows.Forms.Form
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.doneButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.runningWarningLabel = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.World = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.World});
            this.dataGridView.Location = new System.Drawing.Point(15, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(339, 148);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            this.dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserDeletedRow);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(231, 169);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(123, 31);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(156, 169);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(69, 31);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // runningWarningLabel
            // 
            this.runningWarningLabel.AutoSize = true;
            this.runningWarningLabel.Enabled = false;
            this.runningWarningLabel.Location = new System.Drawing.Point(12, 182);
            this.runningWarningLabel.Name = "runningWarningLabel";
            this.runningWarningLabel.Size = new System.Drawing.Size(127, 13);
            this.runningWarningLabel.TabIndex = 7;
            this.runningWarningLabel.Text = "Stop AI to make changes";
            this.runningWarningLabel.Visible = false;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.FillWeight = 40F;
            this.Index.HeaderText = "#";
            this.Index.MinimumWidth = 40;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Width = 40;
            // 
            // World
            // 
            this.World.DataPropertyName = "World";
            this.World.FillWeight = 127F;
            this.World.HeaderText = "Skill";
            this.World.Items.AddRange(new object[] {
            "Skill 1",
            "Skill 2",
            "Skill 3",
            "Skill 4",
            "Skill 5",
            "Skill 6",
            "Skill 7",
            "Skill 8",
            "Skill 9",
            "Skill 10",
            "Skill Awaken 1",
            "Skill Awaken 2",
            "Skill Awaken 3",
            "Skill Awaken 4",
            "Skill Awaken 5"});
            this.World.MinimumWidth = 127;
            this.World.Name = "World";
            this.World.Width = 127;
            // 
            // RaidManualSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 204);
            this.Controls.Add(this.runningWarningLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaidManualSkill";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stage Sequencer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaidManualSkill_FormClosing);
            this.Load += new System.EventHandler(this.RaidManualSkill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private global::System.Windows.Forms.Button clearButton;


        private global::System.ComponentModel.IContainer components;


        private global::System.Windows.Forms.DataGridView dataGridView;


        private global::System.Windows.Forms.Button doneButton;


        private global::System.Windows.Forms.Label runningWarningLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewComboBoxColumn World;
    }
}
