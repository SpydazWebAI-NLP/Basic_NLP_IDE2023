Imports Basic_NLP_Repl.Controls
Imports Basic_NLP_Repl


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNLP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNLP))
        Me.TabControlDocumentDev = New System.Windows.Forms.TabControl()
        Me.TabPageDocumentDevelopment = New System.Windows.Forms.TabPage()
        Me.MasterTabcontrolDocumentDevlopment = New System.Windows.Forms.TabControl()
        Me.TabPageNLP_ = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer10 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer15 = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDownNgrams = New System.Windows.Forms.NumericUpDown()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSearchTerm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxFocused = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ButtonDocumentFrequency = New System.Windows.Forms.Button()
        Me.SplitContainer9 = New System.Windows.Forms.SplitContainer()
        Me.ButtonCorpusFrequency = New System.Windows.Forms.Button()
        Me.ButtonTD_IDF = New System.Windows.Forms.Button()
        Me.DocsLoaded = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpydazWebTabcontrolDocProcessingInputDocuments = New Basic_NLP_Repl.Controls.SpydazWebTabcontrol()
        Me.TabPageInfoHelp = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton8 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripDropDownButton9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextualizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermDocumentMatrixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentCorpusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateTryTreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddByWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddByCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer11 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer14 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripSimularity = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TextboxA_Simularity_NEW = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextboxB_Simularity_NEW = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButtonOpenSimularity = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OpenTextA_Simularity = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTextBSimularity = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetAssociatedTermsToolStripMenuItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TermAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordnetAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatagorysAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SentimentToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordNetBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatagoryBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SentimentToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextAWordnetTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextACatagoricalTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextSentimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBWordNetTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBCatagoricalTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBSentimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompareToolStripMenuItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CompareTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordGramaticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordCatagoricalyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWordnetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SentimentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompareTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextGramaticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextCatagoricalyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextWordNetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SentimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTermA = New System.Windows.Forms.TextBox()
        Me.SplitContainer12 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.TextBoxInputASimularityTest = New System.Windows.Forms.TabControl()
        Me.SplitContainer13 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTermB = New System.Windows.Forms.TextBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.TextBoxInputBSimularityTest = New System.Windows.Forms.TabControl()
        Me.DocumentDevlopmentDocumentToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNewDocument = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonOpenDocument = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSaveDocument = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSaveAsDocument = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonCut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonPrintDocument = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonGeneralHelp = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.TabControlOutPutAnyalsis = New System.Windows.Forms.TabControl()
        Me.TabPageTrieTree = New System.Windows.Forms.TabPage()
        Me.ToolStripTryTree = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNodeCount = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonWordCount = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDepth = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonClearTree = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonSearchTree = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TabPageTDM_DGV = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxOutputSummary = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.DocNewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocOpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocSaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocSaveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DocCutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocCopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocPasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocRedoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocUndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocPrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocHelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ToolStripDocumentDevelopmentOutputDocument = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ToolStripDocumentDevelopmentTextProcessing = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TokenizeCharactersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TokenizeWordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TokenizeSentencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextualizeTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateNgramsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNgramsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNgramstermToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FocusOnSearchTermToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextboxContextualizerSearchTerm = New System.Windows.Forms.ToolStripTextBox()
        Me.NgramSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxNgramSize = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToUpperCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToLowerCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PunctuationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopWordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathsSymbolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BracketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpydazWebTabcontrolDocumentsOutput = New Basic_NLP_Repl.Controls.SpydazWebTabcontrol()
        Me.SpydazWebTabcontrolDocuments = New Basic_NLP_Repl.Controls.SpydazWebTabcontrol()
        Me.TabControlDocumentDev.SuspendLayout()
        Me.TabPageDocumentDevelopment.SuspendLayout()
        Me.MasterTabcontrolDocumentDevlopment.SuspendLayout()
        Me.TabPageNLP_.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer10.Panel1.SuspendLayout()
        Me.SplitContainer10.Panel2.SuspendLayout()
        Me.SplitContainer10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        CType(Me.SplitContainer15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer15.Panel1.SuspendLayout()
        Me.SplitContainer15.Panel2.SuspendLayout()
        Me.SplitContainer15.SuspendLayout()
        CType(Me.NumericUpDownNgrams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer9.Panel1.SuspendLayout()
        Me.SplitContainer9.Panel2.SuspendLayout()
        Me.SplitContainer9.SuspendLayout()
        CType(Me.DocsLoaded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.SuspendLayout()
        Me.TabPageInfoHelp.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.SplitContainer11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer11.Panel1.SuspendLayout()
        Me.SplitContainer11.Panel2.SuspendLayout()
        Me.SplitContainer11.SuspendLayout()
        CType(Me.SplitContainer14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer14.Panel1.SuspendLayout()
        Me.SplitContainer14.Panel2.SuspendLayout()
        Me.SplitContainer14.SuspendLayout()
        Me.ToolStripSimularity.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        CType(Me.SplitContainer12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer12.Panel1.SuspendLayout()
        Me.SplitContainer12.Panel2.SuspendLayout()
        Me.SplitContainer12.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        CType(Me.SplitContainer13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer13.Panel1.SuspendLayout()
        Me.SplitContainer13.Panel2.SuspendLayout()
        Me.SplitContainer13.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.DocumentDevlopmentDocumentToolStrip.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.TabControlOutPutAnyalsis.SuspendLayout()
        Me.TabPageTrieTree.SuspendLayout()
        Me.ToolStripTryTree.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabPageTDM_DGV.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlDocumentDev
        '
        Me.TabControlDocumentDev.Controls.Add(Me.TabPageDocumentDevelopment)
        Me.TabControlDocumentDev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlDocumentDev.Location = New System.Drawing.Point(0, 0)
        Me.TabControlDocumentDev.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TabControlDocumentDev.Name = "TabControlDocumentDev"
        Me.TabControlDocumentDev.SelectedIndex = 0
        Me.TabControlDocumentDev.Size = New System.Drawing.Size(1725, 873)
        Me.TabControlDocumentDev.TabIndex = 1
        '
        'TabPageDocumentDevelopment
        '
        Me.TabPageDocumentDevelopment.BackColor = System.Drawing.Color.Black
        Me.TabPageDocumentDevelopment.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.TabPageDocumentDevelopment.Controls.Add(Me.MasterTabcontrolDocumentDevlopment)
        Me.TabPageDocumentDevelopment.Location = New System.Drawing.Point(4, 24)
        Me.TabPageDocumentDevelopment.Margin = New System.Windows.Forms.Padding(7)
        Me.TabPageDocumentDevelopment.Name = "TabPageDocumentDevelopment"
        Me.TabPageDocumentDevelopment.Padding = New System.Windows.Forms.Padding(7)
        Me.TabPageDocumentDevelopment.Size = New System.Drawing.Size(1717, 845)
        Me.TabPageDocumentDevelopment.TabIndex = 9
        Me.TabPageDocumentDevelopment.Text = "Document Development"
        '
        'MasterTabcontrolDocumentDevlopment
        '
        Me.MasterTabcontrolDocumentDevlopment.Controls.Add(Me.TabPageNLP_)
        Me.MasterTabcontrolDocumentDevlopment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterTabcontrolDocumentDevlopment.Location = New System.Drawing.Point(7, 7)
        Me.MasterTabcontrolDocumentDevlopment.Margin = New System.Windows.Forms.Padding(7)
        Me.MasterTabcontrolDocumentDevlopment.Name = "MasterTabcontrolDocumentDevlopment"
        Me.MasterTabcontrolDocumentDevlopment.SelectedIndex = 0
        Me.MasterTabcontrolDocumentDevlopment.Size = New System.Drawing.Size(1703, 831)
        Me.MasterTabcontrolDocumentDevlopment.TabIndex = 0
        '
        'TabPageNLP_
        '
        Me.TabPageNLP_.BackColor = System.Drawing.Color.Black
        Me.TabPageNLP_.Controls.Add(Me.SplitContainer5)
        Me.TabPageNLP_.Location = New System.Drawing.Point(4, 24)
        Me.TabPageNLP_.Name = "TabPageNLP_"
        Me.TabPageNLP_.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNLP_.Size = New System.Drawing.Size(1695, 803)
        Me.TabPageNLP_.TabIndex = 5
        Me.TabPageNLP_.Text = "Document Processing"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.SplitContainer10)
        Me.SplitContainer5.Panel1.Controls.Add(Me.DocumentDevlopmentDocumentToolStrip)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer5.Size = New System.Drawing.Size(1689, 797)
        Me.SplitContainer5.SplitterDistance = 1003
        Me.SplitContainer5.TabIndex = 0
        '
        'SplitContainer10
        '
        Me.SplitContainer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer10.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer10.Name = "SplitContainer10"
        '
        'SplitContainer10.Panel1
        '
        Me.SplitContainer10.Panel1.Controls.Add(Me.GroupBox11)
        '
        'SplitContainer10.Panel2
        '
        Me.SplitContainer10.Panel2.Controls.Add(Me.SplitContainer11)
        Me.SplitContainer10.Size = New System.Drawing.Size(1003, 758)
        Me.SplitContainer10.SplitterDistance = 579
        Me.SplitContainer10.TabIndex = 10
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Black
        Me.GroupBox11.Controls.Add(Me.SplitContainer7)
        Me.GroupBox11.Controls.Add(Me.ToolStrip2)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox11.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.MintCream
        Me.GroupBox11.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(579, 758)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Natural Language Processing Interface"
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(3, 62)
        Me.SplitContainer7.Name = "SplitContainer7"
        Me.SplitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.BackColor = System.Drawing.Color.Black
        Me.SplitContainer7.Panel1.Controls.Add(Me.SplitContainer8)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.SpydazWebTabcontrolDocProcessingInputDocuments)
        Me.SplitContainer7.Size = New System.Drawing.Size(573, 693)
        Me.SplitContainer7.SplitterDistance = 96
        Me.SplitContainer7.TabIndex = 14
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Name = "SplitContainer8"
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.Controls.Add(Me.SplitContainer15)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer8.Size = New System.Drawing.Size(573, 96)
        Me.SplitContainer8.SplitterDistance = 383
        Me.SplitContainer8.TabIndex = 0
        '
        'SplitContainer15
        '
        Me.SplitContainer15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer15.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer15.Name = "SplitContainer15"
        '
        'SplitContainer15.Panel1
        '
        Me.SplitContainer15.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer15.Panel1.Controls.Add(Me.NumericUpDownNgrams)
        '
        'SplitContainer15.Panel2
        '
        Me.SplitContainer15.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer15.Size = New System.Drawing.Size(383, 96)
        Me.SplitContainer15.SplitterDistance = 78
        Me.SplitContainer15.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(0, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ngram Size"
        '
        'NumericUpDownNgrams
        '
        Me.NumericUpDownNgrams.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NumericUpDownNgrams.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownNgrams.Location = New System.Drawing.Point(0, 66)
        Me.NumericUpDownNgrams.Name = "NumericUpDownNgrams"
        Me.NumericUpDownNgrams.Size = New System.Drawing.Size(78, 30)
        Me.NumericUpDownNgrams.TabIndex = 10
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBoxSearchTerm)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.CheckBoxFocused)
        Me.SplitContainer2.Size = New System.Drawing.Size(301, 96)
        Me.SplitContainer2.SplitterDistance = 239
        Me.SplitContainer2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Location = New System.Drawing.Point(0, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Search Term"
        '
        'TextBoxSearchTerm
        '
        Me.TextBoxSearchTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxSearchTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxSearchTerm.BackColor = System.Drawing.Color.LightYellow
        Me.TextBoxSearchTerm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxSearchTerm.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearchTerm.Location = New System.Drawing.Point(0, 66)
        Me.TextBoxSearchTerm.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TextBoxSearchTerm.Name = "TextBoxSearchTerm"
        Me.TextBoxSearchTerm.Size = New System.Drawing.Size(239, 30)
        Me.TextBoxSearchTerm.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(0, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Focused"
        '
        'CheckBoxFocused
        '
        Me.CheckBoxFocused.AutoSize = True
        Me.CheckBoxFocused.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckBoxFocused.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFocused.Location = New System.Drawing.Point(0, 82)
        Me.CheckBoxFocused.Name = "CheckBoxFocused"
        Me.CheckBoxFocused.Size = New System.Drawing.Size(58, 14)
        Me.CheckBoxFocused.TabIndex = 16
        Me.CheckBoxFocused.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DocsLoaded)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(186, 96)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.ButtonDocumentFrequency)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer9)
        Me.SplitContainer4.Size = New System.Drawing.Size(100, 96)
        Me.SplitContainer4.SplitterDistance = 28
        Me.SplitContainer4.TabIndex = 0
        '
        'ButtonDocumentFrequency
        '
        Me.ButtonDocumentFrequency.BackColor = System.Drawing.Color.Black
        Me.ButtonDocumentFrequency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDocumentFrequency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDocumentFrequency.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDocumentFrequency.ForeColor = System.Drawing.Color.White
        Me.ButtonDocumentFrequency.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ButtonDocumentFrequency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDocumentFrequency.Location = New System.Drawing.Point(0, 0)
        Me.ButtonDocumentFrequency.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.ButtonDocumentFrequency.Name = "ButtonDocumentFrequency"
        Me.ButtonDocumentFrequency.Size = New System.Drawing.Size(100, 28)
        Me.ButtonDocumentFrequency.TabIndex = 7
        Me.ButtonDocumentFrequency.Text = "DF"
        Me.ButtonDocumentFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonDocumentFrequency, "Docuement Frequency")
        Me.ButtonDocumentFrequency.UseVisualStyleBackColor = False
        '
        'SplitContainer9
        '
        Me.SplitContainer9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer9.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer9.Name = "SplitContainer9"
        Me.SplitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer9.Panel1
        '
        Me.SplitContainer9.Panel1.Controls.Add(Me.ButtonCorpusFrequency)
        '
        'SplitContainer9.Panel2
        '
        Me.SplitContainer9.Panel2.Controls.Add(Me.ButtonTD_IDF)
        Me.SplitContainer9.Size = New System.Drawing.Size(100, 64)
        Me.SplitContainer9.SplitterDistance = 27
        Me.SplitContainer9.TabIndex = 0
        '
        'ButtonCorpusFrequency
        '
        Me.ButtonCorpusFrequency.BackColor = System.Drawing.Color.Black
        Me.ButtonCorpusFrequency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCorpusFrequency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCorpusFrequency.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCorpusFrequency.ForeColor = System.Drawing.Color.White
        Me.ButtonCorpusFrequency.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ButtonCorpusFrequency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCorpusFrequency.Location = New System.Drawing.Point(0, 0)
        Me.ButtonCorpusFrequency.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.ButtonCorpusFrequency.Name = "ButtonCorpusFrequency"
        Me.ButtonCorpusFrequency.Size = New System.Drawing.Size(100, 27)
        Me.ButtonCorpusFrequency.TabIndex = 8
        Me.ButtonCorpusFrequency.Text = "CF"
        Me.ButtonCorpusFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonCorpusFrequency, "Corpus Frequency")
        Me.ButtonCorpusFrequency.UseVisualStyleBackColor = False
        '
        'ButtonTD_IDF
        '
        Me.ButtonTD_IDF.BackColor = System.Drawing.Color.Black
        Me.ButtonTD_IDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonTD_IDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTD_IDF.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTD_IDF.ForeColor = System.Drawing.Color.White
        Me.ButtonTD_IDF.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ButtonTD_IDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTD_IDF.Location = New System.Drawing.Point(0, 0)
        Me.ButtonTD_IDF.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.ButtonTD_IDF.Name = "ButtonTD_IDF"
        Me.ButtonTD_IDF.Size = New System.Drawing.Size(100, 33)
        Me.ButtonTD_IDF.TabIndex = 11
        Me.ButtonTD_IDF.Text = "TD/IDF"
        Me.ButtonTD_IDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonTD_IDF, "Term Frequency / Inverse Docuement Frequency")
        Me.ButtonTD_IDF.UseVisualStyleBackColor = False
        '
        'DocsLoaded
        '
        Me.DocsLoaded.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DocsLoaded.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocsLoaded.Location = New System.Drawing.Point(0, 66)
        Me.DocsLoaded.Name = "DocsLoaded"
        Me.DocsLoaded.Size = New System.Drawing.Size(82, 30)
        Me.DocsLoaded.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Corpus Count"
        '
        'SpydazWebTabcontrolDocProcessingInputDocuments
        '
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.Controls.Add(Me.TabPageInfoHelp)
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.Location = New System.Drawing.Point(0, 0)
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.Name = "SpydazWebTabcontrolDocProcessingInputDocuments"
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.SelectedIndex = 0
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.Size = New System.Drawing.Size(573, 593)
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.TabIndex = 15
        '
        'TabPageInfoHelp
        '
        Me.TabPageInfoHelp.Controls.Add(Me.TextBox2)
        Me.TabPageInfoHelp.Location = New System.Drawing.Point(4, 26)
        Me.TabPageInfoHelp.Name = "TabPageInfoHelp"
        Me.TabPageInfoHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInfoHelp.Size = New System.Drawing.Size(565, 563)
        Me.TabPageInfoHelp.TabIndex = 0
        Me.TabPageInfoHelp.Text = "Info"
        Me.TabPageInfoHelp.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(559, 557)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Black
        Me.ToolStrip2.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator8, Me.ToolStripDropDownButton8, Me.ToolStripSeparator7, Me.ToolStripMenuItem15, Me.ToolStripSeparator9})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 20)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(573, 42)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton2.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton2.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_Run
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(79, 39)
        Me.ToolStripButton2.Text = "Run"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 42)
        '
        'ToolStripDropDownButton8
        '
        Me.ToolStripDropDownButton8.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton9, Me.ToolStripDropDownButton6, Me.ToolStripDropDownButton5})
        Me.ToolStripDropDownButton8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton8.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_error
        Me.ToolStripDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton8.Name = "ToolStripDropDownButton8"
        Me.ToolStripDropDownButton8.Size = New System.Drawing.Size(148, 39)
        Me.ToolStripDropDownButton8.Text = "Active Document"
        '
        'ToolStripDropDownButton9
        '
        Me.ToolStripDropDownButton9.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextAToolStripMenuItem1, Me.TextBToolStripMenuItem1})
        Me.ToolStripDropDownButton9.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_UnsucessBuild
        Me.ToolStripDropDownButton9.Name = "ToolStripDropDownButton9"
        Me.ToolStripDropDownButton9.Size = New System.Drawing.Size(226, 24)
        Me.ToolStripDropDownButton9.Text = "Load Current Document"
        '
        'TextAToolStripMenuItem1
        '
        Me.TextAToolStripMenuItem1.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.TextAToolStripMenuItem1.Name = "TextAToolStripMenuItem1"
        Me.TextAToolStripMenuItem1.Size = New System.Drawing.Size(124, 24)
        Me.TextAToolStripMenuItem1.Text = "Text A"
        '
        'TextBToolStripMenuItem1
        '
        Me.TextBToolStripMenuItem1.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.TextBToolStripMenuItem1.Name = "TextBToolStripMenuItem1"
        Me.TextBToolStripMenuItem1.Size = New System.Drawing.Size(124, 24)
        Me.TextBToolStripMenuItem1.Text = "Text B"
        '
        'ToolStripDropDownButton6
        '
        Me.ToolStripDropDownButton6.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11})
        Me.ToolStripDropDownButton6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton6.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_error
        Me.ToolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton6.Name = "ToolStripDropDownButton6"
        Me.ToolStripDropDownButton6.Size = New System.Drawing.Size(226, 24)
        Me.ToolStripDropDownButton6.Text = "Remove"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.CheckOnClick = True
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(173, 24)
        Me.ToolStripMenuItem8.Text = "Punctuation"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.CheckOnClick = True
        Me.ToolStripMenuItem9.Image = CType(resources.GetObject("ToolStripMenuItem9.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(173, 24)
        Me.ToolStripMenuItem9.Text = "Stop Words"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.CheckOnClick = True
        Me.ToolStripMenuItem10.Image = CType(resources.GetObject("ToolStripMenuItem10.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(173, 24)
        Me.ToolStripMenuItem10.Text = "Maths Symbols"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.CheckOnClick = True
        Me.ToolStripMenuItem11.Image = CType(resources.GetObject("ToolStripMenuItem11.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(173, 24)
        Me.ToolStripMenuItem11.Text = "Brackets"
        '
        'ToolStripDropDownButton5
        '
        Me.ToolStripDropDownButton5.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.ToolStripDropDownButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton5.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_SucessBuild
        Me.ToolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton5.Name = "ToolStripDropDownButton5"
        Me.ToolStripDropDownButton5.Size = New System.Drawing.Size(226, 24)
        Me.ToolStripDropDownButton5.Text = "Single Case"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.CheckOnClick = True
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(171, 24)
        Me.ToolStripMenuItem6.Text = "To Upper Case"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.CheckOnClick = True
        Me.ToolStripMenuItem7.Image = CType(resources.GetObject("ToolStripMenuItem7.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(171, 24)
        Me.ToolStripMenuItem7.Text = "To Lower Case"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 42)
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem15.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ContextualizerToolStripMenuItem, Me.TermDocumentMatrixToolStripMenuItem, Me.ToolStripDropDownButton7, Me.CreateTryTreeToolStripMenuItem})
        Me.ToolStripMenuItem15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem15.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem15.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_UnsucessBuild
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(101, 39)
        Me.ToolStripMenuItem15.Text = "Functions"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripMenuItem2.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(235, 24)
        Me.ToolStripMenuItem2.Text = "Create Ngrams (General)"
        '
        'ContextualizerToolStripMenuItem
        '
        Me.ContextualizerToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ContextualizerToolStripMenuItem.Name = "ContextualizerToolStripMenuItem"
        Me.ContextualizerToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.ContextualizerToolStripMenuItem.Text = "Contextualizer"
        '
        'TermDocumentMatrixToolStripMenuItem
        '
        Me.TermDocumentMatrixToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentDocumentToolStripMenuItem, Me.CurrentCorpusToolStripMenuItem})
        Me.TermDocumentMatrixToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Floder
        Me.TermDocumentMatrixToolStripMenuItem.Name = "TermDocumentMatrixToolStripMenuItem"
        Me.TermDocumentMatrixToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.TermDocumentMatrixToolStripMenuItem.Text = "Term Document Matrix"
        '
        'CurrentDocumentToolStripMenuItem
        '
        Me.CurrentDocumentToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.CurrentDocumentToolStripMenuItem.Name = "CurrentDocumentToolStripMenuItem"
        Me.CurrentDocumentToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.CurrentDocumentToolStripMenuItem.Text = "Current Document"
        '
        'CurrentCorpusToolStripMenuItem
        '
        Me.CurrentCorpusToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.CurrentCorpusToolStripMenuItem.Name = "CurrentCorpusToolStripMenuItem"
        Me.CurrentCorpusToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.CurrentCorpusToolStripMenuItem.Text = "Current Corpus"
        '
        'ToolStripDropDownButton7
        '
        Me.ToolStripDropDownButton7.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14})
        Me.ToolStripDropDownButton7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton7.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_UnsucessBuild
        Me.ToolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton7.Name = "ToolStripDropDownButton7"
        Me.ToolStripDropDownButton7.Size = New System.Drawing.Size(235, 24)
        Me.ToolStripDropDownButton7.Text = "Tokenize"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.CheckOnClick = True
        Me.ToolStripMenuItem12.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(207, 24)
        Me.ToolStripMenuItem12.Text = "Tokenize Characters"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.CheckOnClick = True
        Me.ToolStripMenuItem13.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(207, 24)
        Me.ToolStripMenuItem13.Text = "Tokenize Words"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.CheckOnClick = True
        Me.ToolStripMenuItem14.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(207, 24)
        Me.ToolStripMenuItem14.Text = "Tokenize Sentences"
        '
        'CreateTryTreeToolStripMenuItem
        '
        Me.CreateTryTreeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddByWordToolStripMenuItem, Me.AddByCharacterToolStripMenuItem})
        Me.CreateTryTreeToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_FullScreen
        Me.CreateTryTreeToolStripMenuItem.Name = "CreateTryTreeToolStripMenuItem"
        Me.CreateTryTreeToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.CreateTryTreeToolStripMenuItem.Text = "Create Try Tree"
        '
        'AddByWordToolStripMenuItem
        '
        Me.AddByWordToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.AddByWordToolStripMenuItem.Name = "AddByWordToolStripMenuItem"
        Me.AddByWordToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.AddByWordToolStripMenuItem.Text = "Add by Word"
        '
        'AddByCharacterToolStripMenuItem
        '
        Me.AddByCharacterToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.AddByCharacterToolStripMenuItem.Name = "AddByCharacterToolStripMenuItem"
        Me.AddByCharacterToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.AddByCharacterToolStripMenuItem.Text = "Add By Character"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 42)
        '
        'SplitContainer11
        '
        Me.SplitContainer11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer11.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer11.Name = "SplitContainer11"
        Me.SplitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer11.Panel1
        '
        Me.SplitContainer11.Panel1.Controls.Add(Me.SplitContainer14)
        '
        'SplitContainer11.Panel2
        '
        Me.SplitContainer11.Panel2.Controls.Add(Me.SplitContainer12)
        Me.SplitContainer11.Size = New System.Drawing.Size(420, 758)
        Me.SplitContainer11.SplitterDistance = 117
        Me.SplitContainer11.TabIndex = 0
        '
        'SplitContainer14
        '
        Me.SplitContainer14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer14.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer14.Name = "SplitContainer14"
        Me.SplitContainer14.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer14.Panel1
        '
        Me.SplitContainer14.Panel1.BackColor = System.Drawing.Color.Black
        Me.SplitContainer14.Panel1.Controls.Add(Me.ToolStripSimularity)
        '
        'SplitContainer14.Panel2
        '
        Me.SplitContainer14.Panel2.Controls.Add(Me.GroupBox23)
        Me.SplitContainer14.Size = New System.Drawing.Size(420, 117)
        Me.SplitContainer14.SplitterDistance = 48
        Me.SplitContainer14.TabIndex = 0
        '
        'ToolStripSimularity
        '
        Me.ToolStripSimularity.BackColor = System.Drawing.Color.Black
        Me.ToolStripSimularity.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.ToolStripSimularity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripSimularity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripSimularity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton13, Me.ToolStripButtonOpenSimularity, Me.GetAssociatedTermsToolStripMenuItem, Me.CompareToolStripMenuItem})
        Me.ToolStripSimularity.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripSimularity.Name = "ToolStripSimularity"
        Me.ToolStripSimularity.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripSimularity.Size = New System.Drawing.Size(420, 39)
        Me.ToolStripSimularity.TabIndex = 3
        Me.ToolStripSimularity.Text = "ToolStrip1"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextboxA_Simularity_NEW, Me.TextboxB_Simularity_NEW})
        Me.ToolStripButton13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton13.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filenew
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripButton13.Text = "&New"
        '
        'TextboxA_Simularity_NEW
        '
        Me.TextboxA_Simularity_NEW.Name = "TextboxA_Simularity_NEW"
        Me.TextboxA_Simularity_NEW.Size = New System.Drawing.Size(124, 24)
        Me.TextboxA_Simularity_NEW.Text = "Text A"
        '
        'TextboxB_Simularity_NEW
        '
        Me.TextboxB_Simularity_NEW.Name = "TextboxB_Simularity_NEW"
        Me.TextboxB_Simularity_NEW.Size = New System.Drawing.Size(124, 24)
        Me.TextboxB_Simularity_NEW.Text = "Text B"
        '
        'ToolStripButtonOpenSimularity
        '
        Me.ToolStripButtonOpenSimularity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonOpenSimularity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenTextA_Simularity, Me.OpenTextBSimularity})
        Me.ToolStripButtonOpenSimularity.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonOpenSimularity.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_fileopen
        Me.ToolStripButtonOpenSimularity.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonOpenSimularity.Name = "ToolStripButtonOpenSimularity"
        Me.ToolStripButtonOpenSimularity.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripButtonOpenSimularity.Text = "&Open"
        '
        'OpenTextA_Simularity
        '
        Me.OpenTextA_Simularity.Name = "OpenTextA_Simularity"
        Me.OpenTextA_Simularity.Size = New System.Drawing.Size(116, 22)
        Me.OpenTextA_Simularity.Text = "Text A"
        '
        'OpenTextBSimularity
        '
        Me.OpenTextBSimularity.Name = "OpenTextBSimularity"
        Me.OpenTextBSimularity.Size = New System.Drawing.Size(116, 22)
        Me.OpenTextBSimularity.Text = "Text B"
        '
        'GetAssociatedTermsToolStripMenuItem
        '
        Me.GetAssociatedTermsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.GetAssociatedTermsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TermAToolStripMenuItem, Me.TermBToolStripMenuItem, Me.TextAToolStripMenuItem, Me.TextBToolStripMenuItem})
        Me.GetAssociatedTermsToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetAssociatedTermsToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.FileIcon_stickies
        Me.GetAssociatedTermsToolStripMenuItem.Name = "GetAssociatedTermsToolStripMenuItem"
        Me.GetAssociatedTermsToolStripMenuItem.Size = New System.Drawing.Size(194, 36)
        Me.GetAssociatedTermsToolStripMenuItem.Text = "Get Associated Terms"
        '
        'TermAToolStripMenuItem
        '
        Me.TermAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordnetAToolStripMenuItem, Me.CatagorysAToolStripMenuItem, Me.SentimentToolStripMenuItem2})
        Me.TermAToolStripMenuItem.Image = CType(resources.GetObject("TermAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TermAToolStripMenuItem.Name = "TermAToolStripMenuItem"
        Me.TermAToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.TermAToolStripMenuItem.Text = "TermA"
        '
        'WordnetAToolStripMenuItem
        '
        Me.WordnetAToolStripMenuItem.Image = CType(resources.GetObject("WordnetAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordnetAToolStripMenuItem.Name = "WordnetAToolStripMenuItem"
        Me.WordnetAToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.WordnetAToolStripMenuItem.Text = "Wordnet"
        '
        'CatagorysAToolStripMenuItem
        '
        Me.CatagorysAToolStripMenuItem.Image = CType(resources.GetObject("CatagorysAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CatagorysAToolStripMenuItem.Name = "CatagorysAToolStripMenuItem"
        Me.CatagorysAToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.CatagorysAToolStripMenuItem.Text = "Catagorys"
        '
        'SentimentToolStripMenuItem2
        '
        Me.SentimentToolStripMenuItem2.Image = CType(resources.GetObject("SentimentToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.SentimentToolStripMenuItem2.Name = "SentimentToolStripMenuItem2"
        Me.SentimentToolStripMenuItem2.Size = New System.Drawing.Size(141, 24)
        Me.SentimentToolStripMenuItem2.Text = "Sentiment"
        '
        'TermBToolStripMenuItem
        '
        Me.TermBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordNetBToolStripMenuItem, Me.CatagoryBToolStripMenuItem, Me.SentimentToolStripMenuItem3})
        Me.TermBToolStripMenuItem.Image = CType(resources.GetObject("TermBToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TermBToolStripMenuItem.Name = "TermBToolStripMenuItem"
        Me.TermBToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.TermBToolStripMenuItem.Text = "TermB"
        '
        'WordNetBToolStripMenuItem
        '
        Me.WordNetBToolStripMenuItem.Image = CType(resources.GetObject("WordNetBToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordNetBToolStripMenuItem.Name = "WordNetBToolStripMenuItem"
        Me.WordNetBToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.WordNetBToolStripMenuItem.Text = "WordNet"
        '
        'CatagoryBToolStripMenuItem
        '
        Me.CatagoryBToolStripMenuItem.Image = CType(resources.GetObject("CatagoryBToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CatagoryBToolStripMenuItem.Name = "CatagoryBToolStripMenuItem"
        Me.CatagoryBToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.CatagoryBToolStripMenuItem.Text = "Catagory"
        '
        'SentimentToolStripMenuItem3
        '
        Me.SentimentToolStripMenuItem3.Image = CType(resources.GetObject("SentimentToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.SentimentToolStripMenuItem3.Name = "SentimentToolStripMenuItem3"
        Me.SentimentToolStripMenuItem3.Size = New System.Drawing.Size(141, 24)
        Me.SentimentToolStripMenuItem3.Text = "Sentiment"
        '
        'TextAToolStripMenuItem
        '
        Me.TextAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextAWordnetTermsToolStripMenuItem, Me.TextACatagoricalTermsToolStripMenuItem, Me.TextSentimentToolStripMenuItem})
        Me.TextAToolStripMenuItem.Image = CType(resources.GetObject("TextAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextAToolStripMenuItem.Name = "TextAToolStripMenuItem"
        Me.TextAToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.TextAToolStripMenuItem.Text = "TextA"
        '
        'TextAWordnetTermsToolStripMenuItem
        '
        Me.TextAWordnetTermsToolStripMenuItem.Image = CType(resources.GetObject("TextAWordnetTermsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextAWordnetTermsToolStripMenuItem.Name = "TextAWordnetTermsToolStripMenuItem"
        Me.TextAWordnetTermsToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.TextAWordnetTermsToolStripMenuItem.Text = "TextAWordnetTerms"
        '
        'TextACatagoricalTermsToolStripMenuItem
        '
        Me.TextACatagoricalTermsToolStripMenuItem.Image = CType(resources.GetObject("TextACatagoricalTermsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextACatagoricalTermsToolStripMenuItem.Name = "TextACatagoricalTermsToolStripMenuItem"
        Me.TextACatagoricalTermsToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.TextACatagoricalTermsToolStripMenuItem.Text = "TextACatagoricalTerms"
        '
        'TextSentimentToolStripMenuItem
        '
        Me.TextSentimentToolStripMenuItem.Image = CType(resources.GetObject("TextSentimentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextSentimentToolStripMenuItem.Name = "TextSentimentToolStripMenuItem"
        Me.TextSentimentToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.TextSentimentToolStripMenuItem.Text = "TextSentiment"
        '
        'TextBToolStripMenuItem
        '
        Me.TextBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextBWordNetTermsToolStripMenuItem, Me.TextBCatagoricalTermsToolStripMenuItem, Me.TextBSentimentToolStripMenuItem})
        Me.TextBToolStripMenuItem.Image = CType(resources.GetObject("TextBToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextBToolStripMenuItem.Name = "TextBToolStripMenuItem"
        Me.TextBToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.TextBToolStripMenuItem.Text = "TextB"
        '
        'TextBWordNetTermsToolStripMenuItem
        '
        Me.TextBWordNetTermsToolStripMenuItem.Image = CType(resources.GetObject("TextBWordNetTermsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextBWordNetTermsToolStripMenuItem.Name = "TextBWordNetTermsToolStripMenuItem"
        Me.TextBWordNetTermsToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.TextBWordNetTermsToolStripMenuItem.Text = "TextBWordNetTerms"
        '
        'TextBCatagoricalTermsToolStripMenuItem
        '
        Me.TextBCatagoricalTermsToolStripMenuItem.Image = CType(resources.GetObject("TextBCatagoricalTermsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextBCatagoricalTermsToolStripMenuItem.Name = "TextBCatagoricalTermsToolStripMenuItem"
        Me.TextBCatagoricalTermsToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.TextBCatagoricalTermsToolStripMenuItem.Text = "TextBCatagoricalTerms"
        '
        'TextBSentimentToolStripMenuItem
        '
        Me.TextBSentimentToolStripMenuItem.Image = CType(resources.GetObject("TextBSentimentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextBSentimentToolStripMenuItem.Name = "TextBSentimentToolStripMenuItem"
        Me.TextBSentimentToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.TextBSentimentToolStripMenuItem.Text = "TextBSentiment"
        '
        'CompareToolStripMenuItem
        '
        Me.CompareToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CompareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompareTermsToolStripMenuItem, Me.CompareTextToolStripMenuItem})
        Me.CompareToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompareToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.FileIcon_semanticweb
        Me.CompareToolStripMenuItem.Name = "CompareToolStripMenuItem"
        Me.CompareToolStripMenuItem.Size = New System.Drawing.Size(100, 36)
        Me.CompareToolStripMenuItem.Text = "Compare"
        '
        'CompareTermsToolStripMenuItem
        '
        Me.CompareTermsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordGramaticallyToolStripMenuItem, Me.WordCatagoricalyToolStripMenuItem, Me.WordWordnetToolStripMenuItem, Me.SentimentToolStripMenuItem1})
        Me.CompareTermsToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.FileIcon_reminders
        Me.CompareTermsToolStripMenuItem.Name = "CompareTermsToolStripMenuItem"
        Me.CompareTermsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CompareTermsToolStripMenuItem.Text = "Compare Terms"
        '
        'WordGramaticallyToolStripMenuItem
        '
        Me.WordGramaticallyToolStripMenuItem.Image = CType(resources.GetObject("WordGramaticallyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordGramaticallyToolStripMenuItem.Name = "WordGramaticallyToolStripMenuItem"
        Me.WordGramaticallyToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.WordGramaticallyToolStripMenuItem.Text = "Gramatically"
        '
        'WordCatagoricalyToolStripMenuItem
        '
        Me.WordCatagoricalyToolStripMenuItem.Image = CType(resources.GetObject("WordCatagoricalyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordCatagoricalyToolStripMenuItem.Name = "WordCatagoricalyToolStripMenuItem"
        Me.WordCatagoricalyToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.WordCatagoricalyToolStripMenuItem.Text = "Catagoricaly"
        '
        'WordWordnetToolStripMenuItem
        '
        Me.WordWordnetToolStripMenuItem.Image = CType(resources.GetObject("WordWordnetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordWordnetToolStripMenuItem.Name = "WordWordnetToolStripMenuItem"
        Me.WordWordnetToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.WordWordnetToolStripMenuItem.Text = "Wordnet"
        '
        'SentimentToolStripMenuItem1
        '
        Me.SentimentToolStripMenuItem1.Image = CType(resources.GetObject("SentimentToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SentimentToolStripMenuItem1.Name = "SentimentToolStripMenuItem1"
        Me.SentimentToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.SentimentToolStripMenuItem1.Text = "Sentiment"
        '
        'CompareTextToolStripMenuItem
        '
        Me.CompareTextToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextGramaticallyToolStripMenuItem, Me.TextCatagoricalyToolStripMenuItem, Me.TextWordNetToolStripMenuItem, Me.TextGeneralToolStripMenuItem, Me.SentimentToolStripMenuItem})
        Me.CompareTextToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.FileIcon_textedit
        Me.CompareTextToolStripMenuItem.Name = "CompareTextToolStripMenuItem"
        Me.CompareTextToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CompareTextToolStripMenuItem.Text = "Compare Text"
        '
        'TextGramaticallyToolStripMenuItem
        '
        Me.TextGramaticallyToolStripMenuItem.Image = CType(resources.GetObject("TextGramaticallyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextGramaticallyToolStripMenuItem.Name = "TextGramaticallyToolStripMenuItem"
        Me.TextGramaticallyToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TextGramaticallyToolStripMenuItem.Text = "Gramatically"
        '
        'TextCatagoricalyToolStripMenuItem
        '
        Me.TextCatagoricalyToolStripMenuItem.Image = CType(resources.GetObject("TextCatagoricalyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextCatagoricalyToolStripMenuItem.Name = "TextCatagoricalyToolStripMenuItem"
        Me.TextCatagoricalyToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TextCatagoricalyToolStripMenuItem.Text = "Catagoricaly"
        '
        'TextWordNetToolStripMenuItem
        '
        Me.TextWordNetToolStripMenuItem.Image = CType(resources.GetObject("TextWordNetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextWordNetToolStripMenuItem.Name = "TextWordNetToolStripMenuItem"
        Me.TextWordNetToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TextWordNetToolStripMenuItem.Text = "WordNet"
        '
        'TextGeneralToolStripMenuItem
        '
        Me.TextGeneralToolStripMenuItem.Image = CType(resources.GetObject("TextGeneralToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextGeneralToolStripMenuItem.Name = "TextGeneralToolStripMenuItem"
        Me.TextGeneralToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TextGeneralToolStripMenuItem.Text = "General"
        '
        'SentimentToolStripMenuItem
        '
        Me.SentimentToolStripMenuItem.Image = CType(resources.GetObject("SentimentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SentimentToolStripMenuItem.Name = "SentimentToolStripMenuItem"
        Me.SentimentToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SentimentToolStripMenuItem.Text = "Sentiment"
        '
        'GroupBox23
        '
        Me.GroupBox23.BackColor = System.Drawing.Color.Black
        Me.GroupBox23.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.GroupBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox23.Controls.Add(Me.TextBoxTermA)
        Me.GroupBox23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox23.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox23.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox23.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox23.Size = New System.Drawing.Size(420, 65)
        Me.GroupBox23.TabIndex = 5
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Term A"
        '
        'TextBoxTermA
        '
        Me.TextBoxTermA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxTermA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxTermA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxTermA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxTermA.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTermA.Location = New System.Drawing.Point(5, 21)
        Me.TextBoxTermA.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBoxTermA.Name = "TextBoxTermA"
        Me.TextBoxTermA.Size = New System.Drawing.Size(410, 34)
        Me.TextBoxTermA.TabIndex = 4
        '
        'SplitContainer12
        '
        Me.SplitContainer12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer12.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer12.Name = "SplitContainer12"
        Me.SplitContainer12.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer12.Panel1
        '
        Me.SplitContainer12.Panel1.Controls.Add(Me.GroupBox22)
        '
        'SplitContainer12.Panel2
        '
        Me.SplitContainer12.Panel2.Controls.Add(Me.SplitContainer13)
        Me.SplitContainer12.Size = New System.Drawing.Size(420, 637)
        Me.SplitContainer12.SplitterDistance = 261
        Me.SplitContainer12.TabIndex = 0
        '
        'GroupBox22
        '
        Me.GroupBox22.BackColor = System.Drawing.Color.Black
        Me.GroupBox22.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.GroupBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox22.Controls.Add(Me.TextBoxInputASimularityTest)
        Me.GroupBox22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox22.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox22.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox22.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox22.Size = New System.Drawing.Size(420, 261)
        Me.GroupBox22.TabIndex = 5
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Input Text A"
        '
        'TextBoxInputASimularityTest
        '
        Me.TextBoxInputASimularityTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInputASimularityTest.Location = New System.Drawing.Point(5, 21)
        Me.TextBoxInputASimularityTest.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxInputASimularityTest.Name = "TextBoxInputASimularityTest"
        Me.TextBoxInputASimularityTest.SelectedIndex = 0
        Me.TextBoxInputASimularityTest.Size = New System.Drawing.Size(410, 235)
        Me.TextBoxInputASimularityTest.TabIndex = 0
        '
        'SplitContainer13
        '
        Me.SplitContainer13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer13.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer13.Name = "SplitContainer13"
        Me.SplitContainer13.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer13.Panel1
        '
        Me.SplitContainer13.Panel1.Controls.Add(Me.GroupBox25)
        '
        'SplitContainer13.Panel2
        '
        Me.SplitContainer13.Panel2.Controls.Add(Me.GroupBox24)
        Me.SplitContainer13.Size = New System.Drawing.Size(420, 372)
        Me.SplitContainer13.SplitterDistance = 73
        Me.SplitContainer13.TabIndex = 0
        '
        'GroupBox25
        '
        Me.GroupBox25.BackColor = System.Drawing.Color.Black
        Me.GroupBox25.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.GroupBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox25.Controls.Add(Me.TextBoxTermB)
        Me.GroupBox25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox25.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox25.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox25.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox25.Size = New System.Drawing.Size(420, 73)
        Me.GroupBox25.TabIndex = 5
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Term B"
        '
        'TextBoxTermB
        '
        Me.TextBoxTermB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxTermB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxTermB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxTermB.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTermB.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTermB.Location = New System.Drawing.Point(5, 21)
        Me.TextBoxTermB.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBoxTermB.Name = "TextBoxTermB"
        Me.TextBoxTermB.Size = New System.Drawing.Size(410, 34)
        Me.TextBoxTermB.TabIndex = 4
        '
        'GroupBox24
        '
        Me.GroupBox24.BackColor = System.Drawing.Color.Black
        Me.GroupBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox24.Controls.Add(Me.TextBoxInputBSimularityTest)
        Me.GroupBox24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox24.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox24.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox24.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox24.Size = New System.Drawing.Size(420, 295)
        Me.GroupBox24.TabIndex = 6
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Input Text B"
        '
        'TextBoxInputBSimularityTest
        '
        Me.TextBoxInputBSimularityTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInputBSimularityTest.Location = New System.Drawing.Point(5, 21)
        Me.TextBoxInputBSimularityTest.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxInputBSimularityTest.Name = "TextBoxInputBSimularityTest"
        Me.TextBoxInputBSimularityTest.SelectedIndex = 0
        Me.TextBoxInputBSimularityTest.Size = New System.Drawing.Size(410, 269)
        Me.TextBoxInputBSimularityTest.TabIndex = 0
        '
        'DocumentDevlopmentDocumentToolStrip
        '
        Me.DocumentDevlopmentDocumentToolStrip.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.DocumentDevlopmentDocumentToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DocumentDevlopmentDocumentToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DocumentDevlopmentDocumentToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNewDocument, Me.ToolStripButtonOpenDocument, Me.ToolStripButtonSaveDocument, Me.ToolStripButtonSaveAsDocument, Me.ToolStripSeparator12, Me.ToolStripButtonCut, Me.ToolStripButtonCopy, Me.ToolStripButtonPaste, Me.ToolStripButtonUndo, Me.ToolStripButtonRedo, Me.ToolStripSeparator13, Me.ToolStripButtonPrintDocument, Me.ToolStripButtonGeneralHelp})
        Me.DocumentDevlopmentDocumentToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DocumentDevlopmentDocumentToolStrip.Name = "DocumentDevlopmentDocumentToolStrip"
        Me.DocumentDevlopmentDocumentToolStrip.Size = New System.Drawing.Size(1003, 39)
        Me.DocumentDevlopmentDocumentToolStrip.TabIndex = 9
        Me.DocumentDevlopmentDocumentToolStrip.Text = "Application"
        '
        'ToolStripButtonNewDocument
        '
        Me.ToolStripButtonNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNewDocument.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filenew
        Me.ToolStripButtonNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNewDocument.Name = "ToolStripButtonNewDocument"
        Me.ToolStripButtonNewDocument.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonNewDocument.Text = "&New"
        '
        'ToolStripButtonOpenDocument
        '
        Me.ToolStripButtonOpenDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonOpenDocument.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_fileopen
        Me.ToolStripButtonOpenDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonOpenDocument.Name = "ToolStripButtonOpenDocument"
        Me.ToolStripButtonOpenDocument.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonOpenDocument.Text = "&Open"
        '
        'ToolStripButtonSaveDocument
        '
        Me.ToolStripButtonSaveDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSaveDocument.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filesave
        Me.ToolStripButtonSaveDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSaveDocument.Name = "ToolStripButtonSaveDocument"
        Me.ToolStripButtonSaveDocument.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonSaveDocument.Text = "&Save"
        '
        'ToolStripButtonSaveAsDocument
        '
        Me.ToolStripButtonSaveAsDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSaveAsDocument.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filesaveas
        Me.ToolStripButtonSaveAsDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSaveAsDocument.Name = "ToolStripButtonSaveAsDocument"
        Me.ToolStripButtonSaveAsDocument.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonSaveAsDocument.Text = "SaveAs"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButtonCut
        '
        Me.ToolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCut.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editcut
        Me.ToolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCut.Name = "ToolStripButtonCut"
        Me.ToolStripButtonCut.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonCut.Text = "C&ut"
        '
        'ToolStripButtonCopy
        '
        Me.ToolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCopy.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editcopy
        Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
        Me.ToolStripButtonCopy.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonCopy.Text = "&Copy"
        '
        'ToolStripButtonPaste
        '
        Me.ToolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPaste.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editpaste
        Me.ToolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPaste.Name = "ToolStripButtonPaste"
        Me.ToolStripButtonPaste.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonPaste.Text = "&Paste"
        '
        'ToolStripButtonUndo
        '
        Me.ToolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonUndo.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editundo
        Me.ToolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonUndo.Name = "ToolStripButtonUndo"
        Me.ToolStripButtonUndo.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonUndo.Text = "Redo"
        Me.ToolStripButtonUndo.ToolTipText = "Redo"
        '
        'ToolStripButtonRedo
        '
        Me.ToolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRedo.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editredo
        Me.ToolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRedo.Name = "ToolStripButtonRedo"
        Me.ToolStripButtonRedo.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonRedo.Text = "Undo"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButtonPrintDocument
        '
        Me.ToolStripButtonPrintDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPrintDocument.Image = CType(resources.GetObject("ToolStripButtonPrintDocument.Image"), System.Drawing.Image)
        Me.ToolStripButtonPrintDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPrintDocument.Name = "ToolStripButtonPrintDocument"
        Me.ToolStripButtonPrintDocument.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonPrintDocument.Text = "&Print"
        '
        'ToolStripButtonGeneralHelp
        '
        Me.ToolStripButtonGeneralHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonGeneralHelp.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_information
        Me.ToolStripButtonGeneralHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGeneralHelp.Name = "ToolStripButtonGeneralHelp"
        Me.ToolStripButtonGeneralHelp.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonGeneralHelp.Text = "He&lp"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.TabControlOutPutAnyalsis)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer6.Size = New System.Drawing.Size(682, 797)
        Me.SplitContainer6.SplitterDistance = 320
        Me.SplitContainer6.TabIndex = 0
        '
        'TabControlOutPutAnyalsis
        '
        Me.TabControlOutPutAnyalsis.Controls.Add(Me.TabPageTrieTree)
        Me.TabControlOutPutAnyalsis.Controls.Add(Me.TabPageTDM_DGV)
        Me.TabControlOutPutAnyalsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlOutPutAnyalsis.Location = New System.Drawing.Point(0, 0)
        Me.TabControlOutPutAnyalsis.Name = "TabControlOutPutAnyalsis"
        Me.TabControlOutPutAnyalsis.SelectedIndex = 0
        Me.TabControlOutPutAnyalsis.Size = New System.Drawing.Size(682, 320)
        Me.TabControlOutPutAnyalsis.TabIndex = 1
        '
        'TabPageTrieTree
        '
        Me.TabPageTrieTree.Controls.Add(Me.ToolStripTryTree)
        Me.TabPageTrieTree.Controls.Add(Me.GroupBox3)
        Me.TabPageTrieTree.Controls.Add(Me.TreeView1)
        Me.TabPageTrieTree.Location = New System.Drawing.Point(4, 24)
        Me.TabPageTrieTree.Name = "TabPageTrieTree"
        Me.TabPageTrieTree.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTrieTree.Size = New System.Drawing.Size(674, 292)
        Me.TabPageTrieTree.TabIndex = 0
        Me.TabPageTrieTree.Text = "Trie Tree"
        Me.TabPageTrieTree.UseVisualStyleBackColor = True
        '
        'ToolStripTryTree
        '
        Me.ToolStripTryTree.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripTryTree.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripTryTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNodeCount, Me.ToolStripButtonWordCount, Me.ToolStripButtonDepth, Me.ToolStripButtonClearTree})
        Me.ToolStripTryTree.Location = New System.Drawing.Point(3, 194)
        Me.ToolStripTryTree.Name = "ToolStripTryTree"
        Me.ToolStripTryTree.Size = New System.Drawing.Size(668, 39)
        Me.ToolStripTryTree.TabIndex = 7
        '
        'ToolStripButtonNodeCount
        '
        Me.ToolStripButtonNodeCount.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonNodeCount.ForeColor = System.Drawing.Color.White
        Me.ToolStripButtonNodeCount.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Group
        Me.ToolStripButtonNodeCount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNodeCount.Name = "ToolStripButtonNodeCount"
        Me.ToolStripButtonNodeCount.Size = New System.Drawing.Size(109, 36)
        Me.ToolStripButtonNodeCount.Text = "Node Count"
        '
        'ToolStripButtonWordCount
        '
        Me.ToolStripButtonWordCount.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonWordCount.ForeColor = System.Drawing.Color.White
        Me.ToolStripButtonWordCount.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Chat
        Me.ToolStripButtonWordCount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonWordCount.Name = "ToolStripButtonWordCount"
        Me.ToolStripButtonWordCount.Size = New System.Drawing.Size(110, 36)
        Me.ToolStripButtonWordCount.Text = "Word Count"
        '
        'ToolStripButtonDepth
        '
        Me.ToolStripButtonDepth.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonDepth.ForeColor = System.Drawing.Color.White
        Me.ToolStripButtonDepth.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_FullScreen
        Me.ToolStripButtonDepth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDepth.Name = "ToolStripButtonDepth"
        Me.ToolStripButtonDepth.Size = New System.Drawing.Size(78, 36)
        Me.ToolStripButtonDepth.Text = "Depth"
        '
        'ToolStripButtonClearTree
        '
        Me.ToolStripButtonClearTree.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonClearTree.ForeColor = System.Drawing.Color.White
        Me.ToolStripButtonClearTree.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Close
        Me.ToolStripButtonClearTree.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonClearTree.Name = "ToolStripButtonClearTree"
        Me.ToolStripButtonClearTree.Size = New System.Drawing.Size(106, 36)
        Me.ToolStripButtonClearTree.Text = "Clear Tree"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.SplitContainer3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox3.Location = New System.Drawing.Point(3, 194)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Size = New System.Drawing.Size(668, 95)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Tree"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(5, 21)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ButtonSearchTree)
        Me.SplitContainer3.Size = New System.Drawing.Size(658, 69)
        Me.SplitContainer3.SplitterDistance = 494
        Me.SplitContainer3.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 32)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(494, 37)
        Me.TextBox1.TabIndex = 5
        '
        'ButtonSearchTree
        '
        Me.ButtonSearchTree.BackColor = System.Drawing.Color.Black
        Me.ButtonSearchTree.BackgroundImage = CType(resources.GetObject("ButtonSearchTree.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSearchTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSearchTree.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonSearchTree.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearchTree.ForeColor = System.Drawing.Color.White
        Me.ButtonSearchTree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearchTree.Location = New System.Drawing.Point(0, 27)
        Me.ButtonSearchTree.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ButtonSearchTree.Name = "ButtonSearchTree"
        Me.ButtonSearchTree.Size = New System.Drawing.Size(160, 42)
        Me.ButtonSearchTree.TabIndex = 9
        Me.ButtonSearchTree.Text = "Search"
        Me.ButtonSearchTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonSearchTree, "Gets Wordnet Terms for TermA")
        Me.ButtonSearchTree.UseVisualStyleBackColor = False
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TreeView1.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(668, 191)
        Me.TreeView1.TabIndex = 2
        '
        'TabPageTDM_DGV
        '
        Me.TabPageTDM_DGV.Controls.Add(Me.dgv)
        Me.TabPageTDM_DGV.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTDM_DGV.Name = "TabPageTDM_DGV"
        Me.TabPageTDM_DGV.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTDM_DGV.Size = New System.Drawing.Size(674, 294)
        Me.TabPageTDM_DGV.TabIndex = 1
        Me.TabPageTDM_DGV.Text = "Term Document Matrix"
        Me.TabPageTDM_DGV.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(668, 288)
        Me.dgv.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.RichTextBoxOutputSummary)
        Me.GroupBox2.Controls.Add(Me.ToolStrip3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(682, 473)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'RichTextBoxOutputSummary
        '
        Me.RichTextBoxOutputSummary.BackColor = System.Drawing.Color.Beige
        Me.RichTextBoxOutputSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxOutputSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxOutputSummary.Location = New System.Drawing.Point(2, 65)
        Me.RichTextBoxOutputSummary.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.RichTextBoxOutputSummary.Name = "RichTextBoxOutputSummary"
        Me.RichTextBoxOutputSummary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxOutputSummary.Size = New System.Drawing.Size(678, 405)
        Me.RichTextBoxOutputSummary.TabIndex = 11
        Me.RichTextBoxOutputSummary.Text = ""
        Me.ToolTip1.SetToolTip(Me.RichTextBoxOutputSummary, "Summary output Results")
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton7, Me.ToolStripSeparator10, Me.ToolStripButton8, Me.ToolStripSeparator11, Me.ToolStripButton9, Me.ToolStripButton10})
        Me.ToolStrip3.Location = New System.Drawing.Point(2, 26)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(678, 39)
        Me.ToolStrip3.TabIndex = 10
        Me.ToolStrip3.Text = "Application"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_Cancel
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton5.Text = "&Clear"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filesave
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton7.Text = "&Save Text"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Refresh
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton8.Text = "SwapText"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton9.Text = "&Print"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_information
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton10.Text = "He&lp"
        '
        'DocNewToolStripButton
        '
        Me.DocNewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocNewToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filenew
        Me.DocNewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocNewToolStripButton.Name = "DocNewToolStripButton"
        Me.DocNewToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocNewToolStripButton.Text = "&New"
        '
        'DocOpenToolStripButton
        '
        Me.DocOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocOpenToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_fileopen
        Me.DocOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocOpenToolStripButton.Name = "DocOpenToolStripButton"
        Me.DocOpenToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocOpenToolStripButton.Text = "&Open"
        '
        'DocSaveToolStripButton
        '
        Me.DocSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocSaveToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filesave
        Me.DocSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocSaveToolStripButton.Name = "DocSaveToolStripButton"
        Me.DocSaveToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocSaveToolStripButton.Text = "&Save"
        '
        'DocSaveAsToolStripButton
        '
        Me.DocSaveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocSaveAsToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filesaveas
        Me.DocSaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocSaveAsToolStripButton.Name = "DocSaveAsToolStripButton"
        Me.DocSaveAsToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocSaveAsToolStripButton.Text = "SaveAs"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'DocCutToolStripButton
        '
        Me.DocCutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocCutToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editcut
        Me.DocCutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocCutToolStripButton.Name = "DocCutToolStripButton"
        Me.DocCutToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocCutToolStripButton.Text = "C&ut"
        '
        'DocCopyToolStripButton
        '
        Me.DocCopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocCopyToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editcopy
        Me.DocCopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocCopyToolStripButton.Name = "DocCopyToolStripButton"
        Me.DocCopyToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocCopyToolStripButton.Text = "&Copy"
        '
        'DocPasteToolStripButton
        '
        Me.DocPasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocPasteToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editpaste
        Me.DocPasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocPasteToolStripButton.Name = "DocPasteToolStripButton"
        Me.DocPasteToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocPasteToolStripButton.Text = "&Paste"
        '
        'DocRedoToolStripButton
        '
        Me.DocRedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocRedoToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editundo
        Me.DocRedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocRedoToolStripButton.Name = "DocRedoToolStripButton"
        Me.DocRedoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocRedoToolStripButton.Text = "Redo"
        Me.DocRedoToolStripButton.ToolTipText = "Redo"
        '
        'DocUndoToolStripButton
        '
        Me.DocUndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocUndoToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_editredo
        Me.DocUndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocUndoToolStripButton.Name = "DocUndoToolStripButton"
        Me.DocUndoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocUndoToolStripButton.Text = "Undo"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'DocPrintToolStripButton
        '
        Me.DocPrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocPrintToolStripButton.Image = CType(resources.GetObject("DocPrintToolStripButton.Image"), System.Drawing.Image)
        Me.DocPrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocPrintToolStripButton.Name = "DocPrintToolStripButton"
        Me.DocPrintToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocPrintToolStripButton.Text = "&Print"
        '
        'DocHelpToolStripButton
        '
        Me.DocHelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocHelpToolStripButton.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_information
        Me.DocHelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DocHelpToolStripButton.Name = "DocHelpToolStripButton"
        Me.DocHelpToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DocHelpToolStripButton.Text = "He&lp"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Black
        Me.GroupBox6.BackgroundImage = Global.Basic_NLP_Repl.My.Resources.Resources.App_Texturex16
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox6.Size = New System.Drawing.Size(707, 416)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'ToolStripDocumentDevelopmentOutputDocument
        '
        Me.ToolStripDocumentDevelopmentOutputDocument.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStripDocumentDevelopmentOutputDocument.Location = New System.Drawing.Point(5, 371)
        Me.ToolStripDocumentDevelopmentOutputDocument.Name = "ToolStripDocumentDevelopmentOutputDocument"
        Me.ToolStripDocumentDevelopmentOutputDocument.Size = New System.Drawing.Size(697, 39)
        Me.ToolStripDocumentDevelopmentOutputDocument.TabIndex = 9
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_Cancel
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "&Clear"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_filesave
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton11.Text = "&Save Text"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = Global.Basic_NLP_Repl.My.Resources.Resources.App_Refresh
        Me.ToolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton19.Text = "SwapText"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton20.Text = "&Print"
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_information
        Me.ToolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton21.Text = "He&lp"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Black
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox8.Size = New System.Drawing.Size(631, 416)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        '
        'ToolStripDocumentDevelopmentTextProcessing
        '
        Me.ToolStripDocumentDevelopmentTextProcessing.Location = New System.Drawing.Point(5, 19)
        Me.ToolStripDocumentDevelopmentTextProcessing.Name = "ToolStripDocumentDevelopmentTextProcessing"
        Me.ToolStripDocumentDevelopmentTextProcessing.Size = New System.Drawing.Size(621, 42)
        Me.ToolStripDocumentDevelopmentTextProcessing.TabIndex = 1
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton6.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton6.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_Run
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(79, 39)
        Me.ToolStripButton6.Text = "Run"
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripDropDownButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton4.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_Write
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(113, 39)
        Me.ToolStripDropDownButton4.Text = "Functions"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(224, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.White
        Me.ToolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton3.CheckOnClick = True
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton3.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_Event
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(111, 27)
        Me.ToolStripButton3.Text = "Lemmatize"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(224, 6)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton3.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_UnsucessBuild
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(106, 27)
        Me.ToolStripDropDownButton3.Text = "Tokenize"
        '
        'TokenizeCharactersToolStripMenuItem
        '
        Me.TokenizeCharactersToolStripMenuItem.CheckOnClick = True
        Me.TokenizeCharactersToolStripMenuItem.Image = CType(resources.GetObject("TokenizeCharactersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TokenizeCharactersToolStripMenuItem.Name = "TokenizeCharactersToolStripMenuItem"
        Me.TokenizeCharactersToolStripMenuItem.Size = New System.Drawing.Size(240, 28)
        Me.TokenizeCharactersToolStripMenuItem.Text = "Tokenize Characters"
        '
        'TokenizeWordsToolStripMenuItem
        '
        Me.TokenizeWordsToolStripMenuItem.CheckOnClick = True
        Me.TokenizeWordsToolStripMenuItem.Image = CType(resources.GetObject("TokenizeWordsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TokenizeWordsToolStripMenuItem.Name = "TokenizeWordsToolStripMenuItem"
        Me.TokenizeWordsToolStripMenuItem.Size = New System.Drawing.Size(240, 28)
        Me.TokenizeWordsToolStripMenuItem.Text = "Tokenize Words"
        '
        'TokenizeSentencesToolStripMenuItem
        '
        Me.TokenizeSentencesToolStripMenuItem.CheckOnClick = True
        Me.TokenizeSentencesToolStripMenuItem.Image = CType(resources.GetObject("TokenizeSentencesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TokenizeSentencesToolStripMenuItem.Name = "TokenizeSentencesToolStripMenuItem"
        Me.TokenizeSentencesToolStripMenuItem.Size = New System.Drawing.Size(240, 28)
        Me.TokenizeSentencesToolStripMenuItem.Text = "Tokenize Sentences"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(224, 6)
        '
        'ContextualizeTextToolStripMenuItem
        '
        Me.ContextualizeTextToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ContextualizeTextToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ContextualizeTextToolStripMenuItem.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_SucessBuild
        Me.ContextualizeTextToolStripMenuItem.Name = "ContextualizeTextToolStripMenuItem"
        Me.ContextualizeTextToolStripMenuItem.Size = New System.Drawing.Size(227, 28)
        Me.ContextualizeTextToolStripMenuItem.Text = "Contextualize Text"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(224, 6)
        '
        'CreateNgramsToolStripMenuItem2
        '
        Me.CreateNgramsToolStripMenuItem2.BackColor = System.Drawing.Color.White
        Me.CreateNgramsToolStripMenuItem2.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_UnsucessBuild
        Me.CreateNgramsToolStripMenuItem2.Name = "CreateNgramsToolStripMenuItem2"
        Me.CreateNgramsToolStripMenuItem2.Size = New System.Drawing.Size(227, 28)
        Me.CreateNgramsToolStripMenuItem2.Text = "Create Ngrams"
        '
        'CreateNgramsToolStripMenuItem1
        '
        Me.CreateNgramsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateNgramsToolStripMenuItem1.Image = CType(resources.GetObject("CreateNgramsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CreateNgramsToolStripMenuItem1.Name = "CreateNgramsToolStripMenuItem1"
        Me.CreateNgramsToolStripMenuItem1.Size = New System.Drawing.Size(276, 28)
        Me.CreateNgramsToolStripMenuItem1.Text = "Create Ngrams (General)"
        '
        'CreateNgramstermToolStripMenuItem
        '
        Me.CreateNgramstermToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateNgramstermToolStripMenuItem.Image = CType(resources.GetObject("CreateNgramstermToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateNgramstermToolStripMenuItem.Name = "CreateNgramstermToolStripMenuItem"
        Me.CreateNgramstermToolStripMenuItem.Size = New System.Drawing.Size(276, 28)
        Me.CreateNgramstermToolStripMenuItem.Text = "Create Ngrams (term)"
        '
        'FocusOnSearchTermToolStripMenuItem
        '
        Me.FocusOnSearchTermToolStripMenuItem.Name = "FocusOnSearchTermToolStripMenuItem"
        Me.FocusOnSearchTermToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.FocusOnSearchTermToolStripMenuItem.Text = "Focus On SearchTerm"
        '
        'TextboxContextualizerSearchTerm
        '
        Me.TextboxContextualizerSearchTerm.BackColor = System.Drawing.Color.Cornsilk
        Me.TextboxContextualizerSearchTerm.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxContextualizerSearchTerm.Name = "TextboxContextualizerSearchTerm"
        Me.TextboxContextualizerSearchTerm.Size = New System.Drawing.Size(265, 28)
        '
        'NgramSizeToolStripMenuItem
        '
        Me.NgramSizeToolStripMenuItem.Image = CType(resources.GetObject("NgramSizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NgramSizeToolStripMenuItem.Name = "NgramSizeToolStripMenuItem"
        Me.NgramSizeToolStripMenuItem.Size = New System.Drawing.Size(276, 28)
        Me.NgramSizeToolStripMenuItem.Text = "Ngram Size"
        '
        'TextBoxNgramSize
        '
        Me.TextBoxNgramSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxNgramSize.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNgramSize.Name = "TextBoxNgramSize"
        Me.TextBoxNgramSize.Size = New System.Drawing.Size(79, 28)
        Me.TextBoxNgramSize.Text = "2"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(224, 6)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton2.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_SucessBuild
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(127, 27)
        Me.ToolStripDropDownButton2.Text = "Single Case"
        '
        'ToUpperCaseToolStripMenuItem
        '
        Me.ToUpperCaseToolStripMenuItem.CheckOnClick = True
        Me.ToUpperCaseToolStripMenuItem.Image = CType(resources.GetObject("ToUpperCaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToUpperCaseToolStripMenuItem.Name = "ToUpperCaseToolStripMenuItem"
        Me.ToUpperCaseToolStripMenuItem.Size = New System.Drawing.Size(196, 28)
        Me.ToUpperCaseToolStripMenuItem.Text = "To Upper Case"
        '
        'ToLowerCaseToolStripMenuItem
        '
        Me.ToLowerCaseToolStripMenuItem.CheckOnClick = True
        Me.ToLowerCaseToolStripMenuItem.Image = CType(resources.GetObject("ToLowerCaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToLowerCaseToolStripMenuItem.Name = "ToLowerCaseToolStripMenuItem"
        Me.ToLowerCaseToolStripMenuItem.Size = New System.Drawing.Size(196, 28)
        Me.ToLowerCaseToolStripMenuItem.Text = "To Lower Case"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton1.Image = Global.Basic_NLP_Repl.My.Resources.Resources.APP_icon_error
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(95, 27)
        Me.ToolStripDropDownButton1.Text = "Remove"
        '
        'PunctuationToolStripMenuItem
        '
        Me.PunctuationToolStripMenuItem.CheckOnClick = True
        Me.PunctuationToolStripMenuItem.Image = CType(resources.GetObject("PunctuationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PunctuationToolStripMenuItem.Name = "PunctuationToolStripMenuItem"
        Me.PunctuationToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.PunctuationToolStripMenuItem.Text = "Punctuation"
        '
        'StopWordsToolStripMenuItem
        '
        Me.StopWordsToolStripMenuItem.CheckOnClick = True
        Me.StopWordsToolStripMenuItem.Image = CType(resources.GetObject("StopWordsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopWordsToolStripMenuItem.Name = "StopWordsToolStripMenuItem"
        Me.StopWordsToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.StopWordsToolStripMenuItem.Text = "Stop Words"
        '
        'MathsSymbolsToolStripMenuItem
        '
        Me.MathsSymbolsToolStripMenuItem.CheckOnClick = True
        Me.MathsSymbolsToolStripMenuItem.Image = CType(resources.GetObject("MathsSymbolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MathsSymbolsToolStripMenuItem.Name = "MathsSymbolsToolStripMenuItem"
        Me.MathsSymbolsToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.MathsSymbolsToolStripMenuItem.Text = "Maths Symbols"
        '
        'BracketsToolStripMenuItem
        '
        Me.BracketsToolStripMenuItem.CheckOnClick = True
        Me.BracketsToolStripMenuItem.Image = CType(resources.GetObject("BracketsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BracketsToolStripMenuItem.Name = "BracketsToolStripMenuItem"
        Me.BracketsToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.BracketsToolStripMenuItem.Text = "Brackets"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        '
        'SpydazWebTabcontrolDocumentsOutput
        '
        Me.SpydazWebTabcontrolDocumentsOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpydazWebTabcontrolDocumentsOutput.Location = New System.Drawing.Point(5, 19)
        Me.SpydazWebTabcontrolDocumentsOutput.Name = "SpydazWebTabcontrolDocumentsOutput"
        Me.SpydazWebTabcontrolDocumentsOutput.SelectedIndex = 0
        Me.SpydazWebTabcontrolDocumentsOutput.Size = New System.Drawing.Size(697, 352)
        Me.SpydazWebTabcontrolDocumentsOutput.TabIndex = 11
        '
        'SpydazWebTabcontrolDocuments
        '
        Me.SpydazWebTabcontrolDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpydazWebTabcontrolDocuments.Location = New System.Drawing.Point(5, 61)
        Me.SpydazWebTabcontrolDocuments.Name = "SpydazWebTabcontrolDocuments"
        Me.SpydazWebTabcontrolDocuments.SelectedIndex = 0
        Me.SpydazWebTabcontrolDocuments.Size = New System.Drawing.Size(621, 349)
        Me.SpydazWebTabcontrolDocuments.TabIndex = 2
        '
        'FormNLP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1725, 873)
        Me.Controls.Add(Me.TabControlDocumentDev)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FormNLP"
        Me.Text = "Text Anaylsis"
        Me.TabControlDocumentDev.ResumeLayout(False)
        Me.TabPageDocumentDevelopment.ResumeLayout(False)
        Me.MasterTabcontrolDocumentDevlopment.ResumeLayout(False)
        Me.TabPageNLP_.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer10.Panel1.ResumeLayout(False)
        Me.SplitContainer10.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.ResumeLayout(False)
        Me.SplitContainer15.Panel1.ResumeLayout(False)
        Me.SplitContainer15.Panel1.PerformLayout()
        Me.SplitContainer15.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer15.ResumeLayout(False)
        CType(Me.NumericUpDownNgrams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer9.Panel1.ResumeLayout(False)
        Me.SplitContainer9.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer9.ResumeLayout(False)
        CType(Me.DocsLoaded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpydazWebTabcontrolDocProcessingInputDocuments.ResumeLayout(False)
        Me.TabPageInfoHelp.ResumeLayout(False)
        Me.TabPageInfoHelp.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.SplitContainer11.Panel1.ResumeLayout(False)
        Me.SplitContainer11.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer11.ResumeLayout(False)
        Me.SplitContainer14.Panel1.ResumeLayout(False)
        Me.SplitContainer14.Panel1.PerformLayout()
        Me.SplitContainer14.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer14.ResumeLayout(False)
        Me.ToolStripSimularity.ResumeLayout(False)
        Me.ToolStripSimularity.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.SplitContainer12.Panel1.ResumeLayout(False)
        Me.SplitContainer12.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer12.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.SplitContainer13.Panel1.ResumeLayout(False)
        Me.SplitContainer13.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer13.ResumeLayout(False)
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.DocumentDevlopmentDocumentToolStrip.ResumeLayout(False)
        Me.DocumentDevlopmentDocumentToolStrip.PerformLayout()
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        Me.TabControlOutPutAnyalsis.ResumeLayout(False)
        Me.TabPageTrieTree.ResumeLayout(False)
        Me.TabPageTrieTree.PerformLayout()
        Me.ToolStripTryTree.ResumeLayout(False)
        Me.ToolStripTryTree.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabPageTDM_DGV.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlDocumentDev As TabControl
    Friend WithEvents TabPageDocumentDevelopment As TabPage
    Friend WithEvents MasterTabcontrolDocumentDevlopment As TabControl
    Friend WithEvents DocNewToolStripButton As ToolStripButton
    Friend WithEvents DocOpenToolStripButton As ToolStripButton
    Friend WithEvents DocSaveToolStripButton As ToolStripButton
    Friend WithEvents DocSaveAsToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents DocCutToolStripButton As ToolStripButton
    Friend WithEvents DocCopyToolStripButton As ToolStripButton
    Friend WithEvents DocPasteToolStripButton As ToolStripButton
    Friend WithEvents DocRedoToolStripButton As ToolStripButton
    Friend WithEvents DocUndoToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DocPrintToolStripButton As ToolStripButton
    Friend WithEvents DocHelpToolStripButton As ToolStripButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ToolStripDocumentDevelopmentOutputDocument As ToolStrip
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents ToolStripButton19 As ToolStripButton
    Friend WithEvents ToolStripSeparator19 As ToolStripSeparator
    Friend WithEvents ToolStripButton20 As ToolStripButton
    Friend WithEvents ToolStripButton21 As ToolStripButton
    Friend WithEvents SpydazWebTabcontrolDocumentsOutput As SpydazWebTabcontrol
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents ToolStripDocumentDevelopmentTextProcessing As ToolStrip
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents TokenizeCharactersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TokenizeWordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TokenizeSentencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ContextualizeTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CreateNgramsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CreateNgramsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateNgramstermToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FocusOnSearchTermToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextboxContextualizerSearchTerm As ToolStripTextBox
    Friend WithEvents NgramSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxNgramSize As ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToUpperCaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToLowerCaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents PunctuationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopWordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MathsSymbolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BracketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpydazWebTabcontrolDocuments As SpydazWebTabcontrol
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents BS As BindingSource
    Friend WithEvents TabPageNLP_ As TabPage
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents SplitContainer6 As SplitContainer
    Friend WithEvents TabControlOutPutAnyalsis As TabControl
    Friend WithEvents TabPageTrieTree As TabPage
    Friend WithEvents SplitContainer10 As SplitContainer
    Friend WithEvents DocumentDevlopmentDocumentToolStrip As ToolStrip
    Friend WithEvents ToolStripButtonNewDocument As ToolStripButton
    Friend WithEvents ToolStripButtonOpenDocument As ToolStripButton
    Friend WithEvents ToolStripButtonSaveDocument As ToolStripButton
    Friend WithEvents ToolStripButtonSaveAsDocument As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripButtonCut As ToolStripButton
    Friend WithEvents ToolStripButtonCopy As ToolStripButton
    Friend WithEvents ToolStripButtonPaste As ToolStripButton
    Friend WithEvents ToolStripButtonUndo As ToolStripButton
    Friend WithEvents ToolStripButtonRedo As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripButtonPrintDocument As ToolStripButton
    Friend WithEvents ToolStripButtonGeneralHelp As ToolStripButton
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton8 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem15 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents SplitContainer11 As SplitContainer
    Friend WithEvents SplitContainer12 As SplitContainer
    Friend WithEvents SplitContainer13 As SplitContainer
    Friend WithEvents SplitContainer14 As SplitContainer
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents TextBoxTermA As TextBox
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents TextBoxInputASimularityTest As TabControl
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents TextBoxTermB As TextBox
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents TextBoxInputBSimularityTest As TabControl
    Friend WithEvents SplitContainer7 As SplitContainer
    Friend WithEvents SplitContainer8 As SplitContainer
    Friend WithEvents SplitContainer15 As SplitContainer
    Friend WithEvents SpydazWebTabcontrolDocProcessingInputDocuments As SpydazWebTabcontrol
    Friend WithEvents ToolStripSimularity As ToolStrip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDownNgrams As NumericUpDown
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RichTextBoxOutputSummary As RichTextBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents TermDocumentMatrixToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentDocumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentCorpusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton9 As ToolStripMenuItem
    Friend WithEvents TextAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextBToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateTryTreeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddByWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddByCharacterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonSearchTree As Button
    Friend WithEvents ToolStripTryTree As ToolStrip
    Friend WithEvents ToolStripButtonNodeCount As ToolStripButton
    Friend WithEvents ToolStripButtonWordCount As ToolStripButton
    Friend WithEvents ToolStripButtonDepth As ToolStripButton
    Friend WithEvents ToolStripButtonClearTree As ToolStripButton
    Friend WithEvents TabPageInfoHelp As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ToolStripDropDownButton6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents GetAssociatedTermsToolStripMenuItem As ToolStripDropDownButton
    Friend WithEvents TermAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordnetAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatagorysAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SentimentToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TermBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordNetBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatagoryBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SentimentToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents TextAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextAWordnetTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextACatagoricalTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextSentimentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBWordNetTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBCatagoricalTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBSentimentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompareToolStripMenuItem As ToolStripDropDownButton
    Friend WithEvents CompareTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordGramaticallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordCatagoricalyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWordnetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SentimentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CompareTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextGramaticallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextCatagoricalyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextWordNetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SentimentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DocsLoaded As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPageTDM_DGV As TabPage
    Friend WithEvents dgv As DataGridView
    Friend WithEvents ToolStripButton13 As ToolStripDropDownButton
    Friend WithEvents TextboxA_Simularity_NEW As ToolStripMenuItem
    Friend WithEvents TextboxB_Simularity_NEW As ToolStripMenuItem
    Friend WithEvents ToolStripButtonOpenSimularity As ToolStripDropDownButton
    Friend WithEvents OpenTextA_Simularity As ToolStripMenuItem
    Friend WithEvents OpenTextBSimularity As ToolStripMenuItem
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSearchTerm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBoxFocused As CheckBox
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents SplitContainer9 As SplitContainer
    Friend WithEvents ButtonDocumentFrequency As Button
    Friend WithEvents ButtonCorpusFrequency As Button
    Friend WithEvents ButtonTD_IDF As Button
    Friend WithEvents ContextualizerToolStripMenuItem As ToolStripMenuItem
End Class
