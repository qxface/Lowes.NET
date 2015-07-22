<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReloadTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsLowes = New TestSQL.dsLowes()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaItem = New TestSQL.dsLowesTableAdapters.taItem()
        Me.TableAdapterManager = New TestSQL.dsLowesTableAdapters.TableAdapterManager()
        Me.TaMovement = New TestSQL.dsLowesTableAdapters.taMovement()
        Me.bsMovement = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClearItemTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DsLowes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadTablesToolStripMenuItem, Me.ReadTextFileToolStripMenuItem, Me.ClearItemTablesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReloadTablesToolStripMenuItem
        '
        Me.ReloadTablesToolStripMenuItem.Name = "ReloadTablesToolStripMenuItem"
        Me.ReloadTablesToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ReloadTablesToolStripMenuItem.Text = "Reload Tables"
        '
        'ReadTextFileToolStripMenuItem
        '
        Me.ReadTextFileToolStripMenuItem.Name = "ReadTextFileToolStripMenuItem"
        Me.ReadTextFileToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ReadTextFileToolStripMenuItem.Text = "Read Text File"
        '
        'DsLowes
        '
        Me.DsLowes.DataSetName = "dsLowes"
        Me.DsLowes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsItem
        '
        Me.bsItem.DataMember = "dtItem"
        Me.bsItem.DataSource = Me.DsLowes
        '
        'TaItem
        '
        Me.TaItem.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.taItem = Me.TaItem
        Me.TableAdapterManager.taMovement = Me.TaMovement
        Me.TableAdapterManager.UpdateOrder = TestSQL.dsLowesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TaMovement
        '
        Me.TaMovement.ClearBeforeFill = True
        '
        'bsMovement
        '
        Me.bsMovement.DataMember = "dtMovement"
        Me.bsMovement.DataSource = Me.DsLowes
        '
        'ClearItemTablesToolStripMenuItem
        '
        Me.ClearItemTablesToolStripMenuItem.Name = "ClearItemTablesToolStripMenuItem"
        Me.ClearItemTablesToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ClearItemTablesToolStripMenuItem.Text = "Clear Item Tables"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(26, 44)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(39, 13)
        Me.lblProgress.TabIndex = 1
        Me.lblProgress.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 315)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DsLowes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMovement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsLowes As TestSQL.dsLowes
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents TaItem As TestSQL.dsLowesTableAdapters.taItem
    Friend WithEvents TableAdapterManager As TestSQL.dsLowesTableAdapters.TableAdapterManager
    Friend WithEvents TaMovement As TestSQL.dsLowesTableAdapters.taMovement
    Friend WithEvents bsMovement As System.Windows.Forms.BindingSource
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReloadTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearItemTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblProgress As System.Windows.Forms.Label

End Class
