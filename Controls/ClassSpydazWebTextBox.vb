﻿Imports Basic_NLP_Repl.Controls

Namespace Controls

    ''' <summary>
    ''' Customized Text boxes
    ''' </summary>
    Public Class SpydazWebTextBox
        Inherits System.Windows.Forms.RichTextBox

#Region "Main"

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpydazWebTextBox))
            Me.SuspendLayout()
            '
            'ClassInteliTextBox
            '
            Me.AcceptsTab = True
            resources.ApplyResources(Me, "$this")
            'Me.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            'Me.AutoCompleteSource = me.Suggestions
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Tb As SpydazWebTextBox = Me
        Private cmsDropDown As New ContextMenuStrip
        Private Suggestions As IEnumerable(Of String)
        Private IveBeenClicked As Boolean = False
        Private ImAdding As Boolean = False
        Private ImDone As Boolean = False
        Private lastWord As String = ""
        Private LastIndex As Integer = 0
        Private iSyntax As New List(Of String)

        Public Sub New()
            Me.AddReplTerms()
        End Sub

#Region "Terms"

        Public Property MySyntax As List(Of String)
            Get
                Return iSyntax
            End Get
            Set(value As List(Of String))
                iSyntax = value
            End Set
        End Property

        Public Function Checkterm(ByRef str As String) As Boolean
            Checkterm = False
            For Each item In iSyntax
                If item = str Then Return True
            Next
        End Function

        Public Sub ClearTerms()
            Me.iSyntax = New List(Of String)
        End Sub

        Public Sub AddTerm(item As String)

            Me.iSyntax.Add(item)

        End Sub

#End Region

#Region "events"

        Private Sub cmsDropDown_Click(sender As System.Object, e As System.EventArgs)

            cmsDropDown.Close()

            'Get last word of TextBox
            Dim Txt = Strings.Trim(CStr(Me.Text))
            Dim lastIndex As Integer = IIf(Txt.LastIndexOf(" ") = -1, 0, Txt.LastIndexOf(" ") + 1)

            'Set to new value
            With Me
                .SelectionStart = lastIndex
                .SelectionLength = .TextLength
                .SelectedText = sender.text
            End With

            IveBeenClicked = True

        End Sub

        Private Sub SpydazWebTextBox_TextChanged(sender As SpydazWebTextBox, e As EventArgs) Handles Me.TextChanged

            'Exit conditions: ImAdding prevents recursive event call, ImDeleting allows Backspace to work
            If ImAdding Or ImDone Or IveBeenClicked Or Strings.Trim(sender.Text) = "" Then
                cmsDropDown.Close()
                Return
            End If
            'Close old dropdown lists
            cmsDropDown.Close()

            'Get last word entered
            Tb = sender
            Dim CursorPosition As Integer = Tb.SelectionStart
            ' lastWord = GetLastWordEntered(Tb)
            lastWord = sender.GetLastWordEntered
            'Suggestions = GetSuggestions(sender, lastWord)
            Suggestions = sender.GetSuggestions(lastWord)
            '  LastIndex = GetLastIndex(Tb)
            LastIndex = sender.GetLastIndex
            ''Display dropdown list above 3 to stop keep popping up
            If Suggestions.Count > 0 Then

                With cmsDropDown
                    .Items.Clear()
                    For iCount As Integer = 0 To IIf(Suggestions.Count > 100, 65, Suggestions.Count)
                        .Items.Add(Suggestions(iCount))
                        AddHandler .Items(iCount).Click, AddressOf cmsDropDown_Click
                    Next
                    .AutoSize = True
                    .AutoClose = False
                    .Width = Tb.Width
                    .Font = Tb.Font
                    .ForeColor = Color.Aqua
                    .BackColor = Color.Black
                    .BackgroundImage = My.Resources.BackGround_Workspace
                    .BackgroundImageLayout = ImageLayout.Stretch
                    .MaximumSize = New Size(Tb.Width, 300)
                    .LayoutStyle = ToolStripLayoutStyle.Flow
                    .Show(MousePosition.X + 10, MousePosition.Y + 30)

                End With

                'set focus back to original control
                Tb.Focus()
            Else

                cmsDropDown.Close()

            End If
        End Sub

        Private Sub SpydazWebTextBox_KeyDown(sender As SpydazWebTextBox, e As KeyEventArgs) Handles Me.KeyDown
            Dim newWord As String = ""
            Select Case e.KeyCode

                'inserts Suggestion
                Case Keys.Tab
                    If Suggestions IsNot Nothing Then
                        ImAdding = True
                        Dim CursorPosition As Integer = sender.SelectionStart
                        'Append word if available (autoSelect)
                        If Not (Suggestions(0) Is Nothing) Then
                            newWord = Suggestions(0)
                        End If
                        'If tb.SelectionLength = 0 Then
                        Dim Txt = Strings.Trim(CStr(Tb.Text))
                        Dim lastIndex As Integer = IIf(Txt.LastIndexOf(" ") = -1, 0, Txt.LastIndexOf(" ") + 1)
                        Dim Pos As Integer = 0
                        'Set to new value
                        If newWord <> "" Then
                            With sender
                                .SelectionStart = lastIndex
                                .SelectionLength = .TextLength
                                .SelectedText = newWord
                                Pos = .TextLength
                            End With
                            newWord = ""
                        End If
                        'End If

                        sender.SelectionStart = Pos

                        ImDone = True
                        IveBeenClicked = True
                        e.SuppressKeyPress = True
                    Else
                        ImDone = True
                        IveBeenClicked = False
                        e.SuppressKeyPress = False

                    End If
                'Cancel Suggestion
                Case Keys.Space
                    ImDone = True
                    IveBeenClicked = False
                    newWord = ""
                    cmsDropDown.Close()
                'Auto highlight
                Case Keys.Enter
                    Dim CursorPosition As Integer = sender.SelectionStart
                    sender.HighlightMySyntax
                    sender.SelectionStart = CursorPosition
                'Manual Highlight text (for rtb)
                Case Keys.Home
                    Dim CursorPosition As Integer = sender.SelectionStart
                    sender.HighlightMySyntax
                    sender.SelectionStart = CursorPosition
            End Select
        End Sub

#End Region

    End Class

End Namespace

''' <summary>
''' SpydazWeb textbox Extensions
''' </summary>
Public Module SpydazWebTextBoxExtensions

    Public ReplTerms() As String = ({"SPYDAZ", "ABS", "ACCESS", "ADDITEM", "ADDNEW", "ALIAS", "AND", "ANY", "APP", "APPACTIVATE", "APPEND", "APPENDCHUNK", "ARRANGE", "AS", "ASC", "ATN", "BASE", "BEEP", "BEGINTRANS", "BINARY", "BYVAL", "CALL", "CASE", "CCUR", "CDBL", "CHDIR", "CHDRIVE", "CHR", "CHR$", "CINT", "CIRCLE", "CLEAR", "CLIPBOARD", "CLNG", "CLOSE", "CLS", "COMMAND", "
COMMAND$", "COMMITTRANS", "COMPARE", "CONST", "CONTROL", "CONTROLS", "COS", "CREATEDYNASET", "CSNG", "CSTR", "CURDIR$", "CURRENCY", "CVAR", "CVDATE", "DATA", "DATE", "DATE$", "DIM", "DATESERIAL", "DATEVALUE", "DAY", "
DEBUG", "DECLARE", "DEFCUR", "CEFDBL", "DEFINT", "DEFLNG", "DEFSNG", "DEFSTR", "DEFVAR", "DELETE", "DIM", "DIR", "DIR$", "DO", "DOEVENTS", "DOUBLE", "DRAG", "DYNASET", "EDIT", "ELSE", "ELSEIF", "END", "ENDDOC", "ENDIF", "
ENVIRON$", "EOF", "EQV", "ERASE", "ERL", "ERR", "ERROR", "ERROR$", "EXECUTESQL", "EXIT", "EXP", "EXPLICIT", "FALSE", "FIELDSIZE", "FILEATTR", "FILECOPY", "FILEDATETIME", "FILELEN", "FIX", "FOR", "FORM", "FORMAT", "
FORMAT$", "FORMS", "FREEFILE", "FUNCTION", "GET", "GETATTR", "GETCHUNK", "GETDATA", "DETFORMAT", "GETTEXT", "GLOBAL", "GOSUB", "GOTO", "HEX", "HEX$", "HIDE", "HOUR", "IF", "IMP", "INPUT", "INPUT$", "INPUTBOX", "INPUTBOX$", "
INSTR", "INT", "INTEGER", "IS", "ISDATE", "ISEMPTY", "ISNULL", "ISNUMERIC", "KILL", "LBOUND", "LCASE", "LCASE$", "LEFT", "LEFT$", "LEN", "LET", "LIB", "LIKE", "LINE", "LINKEXECUTE", "LINKPOKE", "LINKREQUEST", "
LINKSEND", "LOAD", "LOADPICTURE", "LOC", "LOCAL", "LOCK", "LOF", "LOG", "LONG", "LOOP", "LSET", "LTRIM",
  "LTRIM$", "ME", "MID", "MID$", "MINUTE", "MKDIR", "MOD", "MONTH", "MOVE", "MOVEFIRST", "MOVELAST", "MOVENEXT", "MOVEPREVIOUS",
  "MOVERELATIVE", "MSGBOX", "NAME", "NEW", "NEWPAGE", "NEXT", "NEXTBLOCK", "NOT", "NOTHING",
  "NOW", "NULL", "OCT", "OCT$", "ON", "OPEN", "OPENDATABASE", "OPTION", "OR", "OUTPUT", "POINT", "PRESERVE", "PRINT",
  "PRINTER", "PRINTFORM", "PRIVATE", "PSET", "PUT", "PUBLIC", "QBCOLOR", "RANDOM", "RANDOMIZE", "READ", "REDIM", "REFRESH",
  "REGISTERDATABASE", "REM", "REMOVEITEM", "RESET", "RESTORE", "RESUME", "RETURN", "RGB", "RIGHT", "RIGHT$", "RMDIR", "RND",
  "ROLLBACK", "RSET", "RTRIM", "RTRIM$", "SAVEPICTURE", "SCALE", "SECOND", "SEEK", "SELECT", "SENDKEYS", "SET", "SETATTR",
  "SETDATA", "SETFOCUS", "SETTEXT", "SGN", "SHARED",
  "SHELL", "SHOW", "SIN", "SINGLE", "SPACE", "SPACE$", "SPC", "SQR",
  "STATIC", "STEP", "STOP", "STR", "STR$", "STRCOMP", "STRING", "STRING$", "SUB",
  "SYSTEM", "TAB", "TAN", "TEXT", "TEXTHEIGHT", "TEXTWIDTH", "THEN", "TIME", "TIME$",
  "TIMER", "TIMESERIAL", "TIMEVALUE", "TO", "TRIM",
  "TRIM$", "TRUE", "TYPE", "TYPEOF", "UBOUND", "UCASE", "UCASE$", "UNLOAD",
  "UNLOCK", "UNTIL", "UPDATE", "USING", "VAL", "VARIANT", "VARTYPE", "WEEKDAY", "WEND", "WHILE", "WIDTH",
  "WRITE", "XOR", "YEAR", "ZORDER", "ADDHANDLER", "ADDRESSOF", "ALIAS", "AND", "ANDALSO", "AS", "BYREF",
  "BOOLEAN", "BYTE", "BYVAL", "CALL", "CASE", "CATCH", "CBOOL", "CBYTE", "CCHAR", "CDATE",
  "CDEC", "CDBL", "CHAR", "CINT", "CLASS", "CLNG", "COBJ", "CONST", "CONTINUE", "CSBYTE",
  "CSHORT", "CSNG", "CSTR", "CTYPE", "CUINT", "CULNG", "CUSHORT", "DATE", "DECIMAL", "DECLARE",
  "DEFAULT", "DELEGATE", "DIM", "DIRECTCAST", "DOUBLE", "DO", "EACH", "ELSE", "ELSEIF", "END",
  "ENDIF", "ENUM", "ERASE", "ERROR", "EVENT", "EXIT", "FALSE", "FINALLY", "FOR", "FRIEND",
  "FUNCTION", "GET", "GETTYPE", "GLOBAL", "GOSUB", "GOTO", "HANDLES", "IF", "IMPLEMENTS",
  "IMPORTS", "IN", "INHERITS", "INTEGER", "INTERFACE", "IS", "ISNOT", "LET", "LIB", "LIKE",
  "LONG", "LOOP", "ME", "MOD", "MODULE", "MUSTINHERIT", "MUSTOVERRIDE", "MYBASE", "MYCLASS",
  "NAMESPACE", "NARROWING", "NEW", "NEXT", "NOT", "NOTHING", "NOTINHERITABLE", "NOTOVERRIDABLE",
  "OBJECT", "ON", "OF", "OPERATOR", "OPTION", "OPTIONAL", "OR", "ORELSE", "OVERLOADS",
  "OVERRIDABLE", "OVERRIDES", "PARAMARRAY", "PARTIAL", "PRIVATE", "PROPERTY", "PROTECTED",
  "PUBLIC", "RAISEEVENT", "READONLY", "REDIM", "REM", "REMOVEHANDLER", "RESUME", "RETURN",
  "SBYTE", "SELECT", "SET", "SHADOWS", "SHARED", "SHORT", "SINGLE", "STATIC", "STEP", "STOP",
  "STRING", "STRUCTURE", "SUB", "SYNCLOCK", "THEN", "THROW", "TO", "TRUE", "TRY", "TRYCAST",
  "TYPEOF", "WEND", "VARIANT", "UINTEGER", "ULONG", "USHORT", "USING", "WHEN", "WHILE", "WIDENING",
  "WITH", "WITHEVENTS", "WRITEONLY", "XOR", "#CONST", "#ELSE", "#ELSEIF", "#END", "#IF"})

    <Runtime.CompilerServices.Extension()>
    Public Sub HighlightMySyntax(ByRef Sender As SpydazWebTextBox)
        Highlighter.SearchSyntax(Sender, Sender.MySyntax)
    End Sub

    <Runtime.CompilerServices.Extension()>
    Public Function AddReplTerms(ByRef Sender As SpydazWebTextBox) As SpydazWebTextBox
        For Each item In ReplTerms
            If Sender.Checkterm(item) = False Then
                Sender.AddTerm(item)
            End If
        Next
        Return Sender
    End Function

    <Runtime.CompilerServices.Extension()>
    Public Function GetSuggestions(ByVal Sender As SpydazWebTextBox, ByVal LastWord As String) As IEnumerable(Of String)
        Dim QueryStR As String = UCase(LastWord)
        'Get word suggestions based on word start for Append function
        Dim StringList As New List(Of String)
        For Each c In Sender.MySyntax
            StringList.Add(UCase(c))
        Next
        Dim iSuggestions As IEnumerable(Of String) = From c In StringList Where c.StartsWith(QueryStR, StringComparison.InvariantCultureIgnoreCase) Select c
        ''Reset suggestion list to 'contains' if list is small - NOW CASE SENSITIVE
        If iSuggestions.Count = 0 Then
            iSuggestions = From c In StringList Where c.IndexOf(LastWord, StringComparison.InvariantCultureIgnoreCase) <> -1 Select c 'c.Contains(lastWord)
        End If
        Return iSuggestions
    End Function

End Module
''' <summary>
''' Rich TextBox Extensions
''' </summary>
Public Module RichTextBoxExtensions

    ''' <summary>
    ''' returns last word entered into box
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetLastWordEntered(ByRef Sender As RichTextBox) As String
        'Get last word entered
        Dim tb = Sender
        Try
            Dim CursorPosition As Integer = Sender.SelectionStart
            Dim Txt = Strings.Trim(CStr(tb.Text))
            Dim lastIndex As Integer = IIf(Txt.LastIndexOf(" ") = -1, 0, Txt.LastIndexOf(" ") + 1)
            Dim lastWord As String = Strings.Trim(Txt.Substring(lastIndex))
            Return lastWord
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "GetLastWordEntered Error ")
        End Try
        Return ""
    End Function

    ''' <summary>
    ''' Gets the last index of the last word entered
    ''' </summary>
    ''' <param name="sender">rich text box</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetLastIndex(ByRef sender As RichTextBox) As Integer
        'Get last word entered
        Dim Tb = sender
        Dim CursorPosition As Integer = Tb.SelectionStart
        Dim Txt = Strings.Trim(CStr(Tb.Text))
        Dim lastIndex As Integer = IIf(Txt.LastIndexOf(" ") = -1, 0, Txt.LastIndexOf(" ") + 1)
        Return lastIndex
    End Function

    ''' <summary>
    ''' Highlights a specific word
    ''' </summary>
    ''' <param name="sender">richtextbox</param>
    ''' <param name="word"></param>
    <Runtime.CompilerServices.Extension()>
    Public Sub HighlightWord(ByRef sender As RichTextBox, ByRef word As String)
        Highlighter.HighlightWord(sender, word)
    End Sub

End Module

''' <summary>
''' Colors Words in RichText Box
''' </summary>
Public Class Highlighter

    ''' <summary>
    ''' Returns Propercase Sentence
    ''' </summary>
    ''' <param name="TheString">String to be formatted</param>
    ''' <returns></returns>
    Private Shared Function ProperCase(ByRef TheString As String) As String
        ProperCase = UCase(Strings.Left(TheString, 1))

        For i = 2 To Len(TheString)

            ProperCase = If(Mid(TheString, i - 1, 1) = " ", ProperCase & UCase(Mid(TheString, i, 1)), ProperCase & LCase(Mid(TheString, i, 1)))
        Next i
    End Function

    Public Shared SyntaxTerms() As String = ({"SPYDAZ", "ABS", "ACCESS", "ADDITEM", "ADDNEW", "ALIAS", "AND", "ANY", "APP", "APPACTIVATE", "APPEND", "APPENDCHUNK", "ARRANGE", "AS", "ASC", "ATN", "BASE", "BEEP", "BEGINTRANS", "BINARY", "BYVAL", "CALL", "CASE", "CCUR", "CDBL", "CHDIR", "CHDRIVE", "CHR", "CHR$", "CINT", "CIRCLE", "CLEAR", "CLIPBOARD", "CLNG", "CLOSE", "CLS", "COMMAND", "
COMMAND$", "COMMITTRANS", "COMPARE", "CONST", "CONTROL", "CONTROLS", "COS", "CREATEDYNASET", "CSNG", "CSTR", "CURDIR$", "CURRENCY", "CVAR", "CVDATE", "DATA", "DATE", "DATE$", "DIM", "DATESERIAL", "DATEVALUE", "DAY", "
DEBUG", "DECLARE", "DEFCUR", "CEFDBL", "DEFINT", "DEFLNG", "DEFSNG", "DEFSTR", "DEFVAR", "DELETE", "DIM", "DIR", "DIR$", "DO", "DOEVENTS", "DOUBLE", "DRAG", "DYNASET", "EDIT", "ELSE", "ELSEIF", "END", "ENDDOC", "ENDIF", "
ENVIRON$", "EOF", "EQV", "ERASE", "ERL", "ERR", "ERROR", "ERROR$", "EXECUTESQL", "EXIT", "EXP", "EXPLICIT", "FALSE", "FIELDSIZE", "FILEATTR", "FILECOPY", "FILEDATETIME", "FILELEN", "FIX", "FOR", "FORM", "FORMAT", "
FORMAT$", "FORMS", "FREEFILE", "FUNCTION", "GET", "GETATTR", "GETCHUNK", "GETDATA", "DETFORMAT", "GETTEXT", "GLOBAL", "GOSUB", "GOTO", "HEX", "HEX$", "HIDE", "HOUR", "IF", "IMP", "INPUT", "INPUT$", "INPUTBOX", "INPUTBOX$", "
INSTR", "INT", "INTEGER", "IS", "ISDATE", "ISEMPTY", "ISNULL", "ISNUMERIC", "KILL", "LBOUND", "LCASE", "LCASE$", "LEFT", "LEFT$", "LEN", "LET", "LIB", "LIKE", "LINE", "LINKEXECUTE", "LINKPOKE", "LINKREQUEST", "
LINKSEND", "LOAD", "LOADPICTURE", "LOC", "LOCAL", "LOCK", "LOF", "LOG", "LONG", "LOOP", "LSET", "LTRIM",
    "LTRIM$", "ME", "MID", "MID$", "MINUTE", "MKDIR", "MOD", "MONTH", "MOVE", "MOVEFIRST", "MOVELAST", "MOVENEXT", "MOVEPREVIOUS",
    "MOVERELATIVE", "MSGBOX", "NAME", "NEW", "NEWPAGE", "NEXT", "NEXTBLOCK", "NOT", "NOTHING",
    "NOW", "NULL", "OCT", "OCT$", "ON", "OPEN", "OPENDATABASE", "OPTION", "OR", "OUTPUT", "POINT", "PRESERVE", "PRINT",
    "PRINTER", "PRINTFORM", "PRIVATE", "PSET", "PUT", "PUBLIC", "QBCOLOR", "RANDOM", "RANDOMIZE", "READ", "REDIM", "REFRESH",
    "REGISTERDATABASE", "REM", "REMOVEITEM", "RESET", "RESTORE", "RESUME", "RETURN", "RGB", "RIGHT", "RIGHT$", "RMDIR", "RND",
    "ROLLBACK", "RSET", "RTRIM", "RTRIM$", "SAVEPICTURE", "SCALE", "SECOND", "SEEK", "SELECT", "SENDKEYS", "SET", "SETATTR",
    "SETDATA", "SETFOCUS", "SETTEXT", "SGN", "SHARED",
    "SHELL", "SHOW", "SIN", "SINGLE", "SPACE", "SPACE$", "SPC", "SQR",
    "STATIC", "STEP", "STOP", "STR", "STR$", "STRCOMP", "STRING", "STRING$", "SUB",
    "SYSTEM", "TAB", "TAN", "TEXT", "TEXTHEIGHT", "TEXTWIDTH", "THEN", "TIME", "TIME$",
    "TIMER", "TIMESERIAL", "TIMEVALUE", "TO", "TRIM",
    "TRIM$", "TRUE", "TYPE", "TYPEOF", "UBOUND", "UCASE", "UCASE$", "UNLOAD",
    "UNLOCK", "UNTIL", "UPDATE", "USING", "VAL", "VARIANT", "VARTYPE", "WEEKDAY", "WEND", "WHILE", "WIDTH",
    "WRITE", "XOR", "YEAR", "ZORDER", "ADDHANDLER", "ADDRESSOF", "ALIAS", "AND", "ANDALSO", "AS", "BYREF",
    "BOOLEAN", "BYTE", "BYVAL", "CALL", "CASE", "CATCH", "CBOOL", "CBYTE", "CCHAR", "CDATE",
    "CDEC", "CDBL", "CHAR", "CINT", "CLASS", "CLNG", "COBJ", "CONST", "CONTINUE", "CSBYTE",
    "CSHORT", "CSNG", "CSTR", "CTYPE", "CUINT", "CULNG", "CUSHORT", "DATE", "DECIMAL", "DECLARE",
    "DEFAULT", "DELEGATE", "DIM", "DIRECTCAST", "DOUBLE", "DO", "EACH", "ELSE", "ELSEIF", "END",
    "ENDIF", "ENUM", "ERASE", "ERROR", "EVENT", "EXIT", "FALSE", "FINALLY", "FOR", "FRIEND",
    "FUNCTION", "GET", "GETTYPE", "GLOBAL", "GOSUB", "GOTO", "HANDLES", "IF", "IMPLEMENTS",
    "IMPORTS", "IN", "INHERITS", "INTEGER", "INTERFACE", "IS", "ISNOT", "LET", "LIB", "LIKE",
    "LONG", "LOOP", "ME", "MOD", "MODULE", "MUSTINHERIT", "MUSTOVERRIDE", "MYBASE", "MYCLASS",
    "NAMESPACE", "NARROWING", "NEW", "NEXT", "NOT", "NOTHING", "NOTINHERITABLE", "NOTOVERRIDABLE",
    "OBJECT", "ON", "OF", "OPERATOR", "OPTION", "OPTIONAL", "OR", "ORELSE", "OVERLOADS",
    "OVERRIDABLE", "OVERRIDES", "PARAMARRAY", "PARTIAL", "PRIVATE", "PROPERTY", "PROTECTED",
    "PUBLIC", "RAISEEVENT", "READONLY", "REDIM", "REM", "REMOVEHANDLER", "RESUME", "RETURN",
    "SBYTE", "SELECT", "SET", "SHADOWS", "SHARED", "SHORT", "SINGLE", "STATIC", "STEP", "STOP",
    "STRING", "STRUCTURE", "SUB", "SYNCLOCK", "THEN", "THROW", "TO", "TRUE", "TRY", "TRYCAST",
    "TYPEOF", "WEND", "VARIANT", "UINTEGER", "ULONG", "USHORT", "USING", "WHEN", "WHILE", "WIDENING",
    "WITH", "WITHEVENTS", "WRITEONLY", "XOR", "#CONST", "#ELSE", "#ELSEIF", "#END", "#IF"})

    Private Shared indexOfSearchText As Integer = 0

    Private Shared start As Integer = 0

    Private mGrammar As New List(Of String)

    Public Shared Sub ColorSearchTerm(ByRef SearchStr As String, Rtb As RichTextBox)
        ColorSearchTerm(SearchStr, Rtb, Color.CadetBlue)
    End Sub

    Public Shared Sub ColorSearchTerm(ByRef SearchStr As String, Rtb As RichTextBox, ByRef MyColor As Color)
        Dim startindex As Integer = 0
        start = 0
        indexOfSearchText = 0

        If SearchStr <> "" Then

            SearchStr = SearchStr & " "
            If SearchStr.Length > 0 Then
                startindex = FindText(Rtb, ProperCase(SearchStr), start, Rtb.Text.Length)
            End If
            If SearchStr.Length > 0 And startindex = 0 Then
                startindex = FindText(Rtb, LCase(SearchStr), start, Rtb.Text.Length)
            End If
            If SearchStr.Length > 0 And startindex = 0 Then
                startindex = FindText(Rtb, UCase(SearchStr), start, Rtb.Text.Length)
            End If
            If SearchStr.Length > 0 And startindex = 0 Then
                startindex = FindText(Rtb, SearchStr, start, Rtb.Text.Length)
            End If
            ' If string was found in the RichTextBox, highlight it
            If startindex >= 0 Then
                ' Set the highlight color as red
                Rtb.SelectionColor = MyColor

                ' Find the end index. End Index = number of characters in textbox
                Dim endindex As Integer = SearchStr.Length
                ' Highlight the search string

                Rtb.Select(startindex, endindex)
                Rtb.SelectedText.ToUpper()
                ' mark the start position after the position of last search string
                start = startindex + endindex

            End If
        Else
        End If
        Rtb.Select(Rtb.TextLength, Rtb.TextLength)
    End Sub

    ''' <summary>
    ''' Searches For Internal Syntax
    ''' </summary>
    ''' <param name="Rtb"></param>
    ''' <remarks></remarks>
    Public Shared Sub SearchSyntax(ByRef Rtb As RichTextBox)
        'Searches Basic Syntax
        For Each wrd As String In SyntaxTerms
            start = 0
            indexOfSearchText = 0
            ColorSearchTerm(wrd, Rtb)
        Next
        For Each wrd As String In SyntaxTerms
            start = 0
            indexOfSearchText = 0
            ColorSearchTerm(wrd, Rtb)
        Next
    End Sub

    ''' <summary>
    ''' Searches For Internal Syntax
    ''' </summary>
    ''' <param name="Rtb"></param>
    ''' <remarks></remarks>
    Public Shared Sub SearchSyntax(ByRef Rtb As RichTextBox, ByRef Terms As List(Of String))
        'Searches Basic Syntax
        For Each wrd As String In SyntaxTerms
            start = 0
            indexOfSearchText = 0
            ColorSearchTerm(wrd, Rtb)
        Next
        For Each wrd As String In Terms
            start = 0
            indexOfSearchText = 0
            ColorSearchTerm(UCase(wrd), Rtb)
        Next
    End Sub

    ''' <summary>
    ''' Searches for Specific Word to colorize (Blue)
    ''' </summary>
    ''' <param name="Rtb"></param>
    ''' <param name="SearchStr"></param>
    ''' <remarks></remarks>
    Public Shared Sub SearchSyntax(ByRef Rtb As RichTextBox, ByRef SearchStr As String)
        start = 0
        indexOfSearchText = 0
        ColorSearchTerm(SearchStr, Rtb)
    End Sub

    ''' <summary>
    ''' Searches for Specfic word to colorize specified color
    ''' </summary>
    ''' <param name="Rtb"></param>
    ''' <param name="SearchStr"></param>
    ''' <param name="MyColor"></param>
    ''' <remarks></remarks>
    Public Shared Sub SearchSyntax(ByRef Rtb As RichTextBox, ByRef SearchStr As String, MyColor As Color)

        start = 0
        indexOfSearchText = 0
        ColorSearchTerm(SearchStr, Rtb, MyColor)

    End Sub

    Private Shared Function FindText(ByRef Rtb As RichTextBox, SearchStr As String,
                                                        ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer

        ' Unselect the previously searched string
        If searchStart > 0 AndAlso searchEnd > 0 AndAlso indexOfSearchText >= 0 Then
            Rtb.Undo()
        End If

        ' Set the return value to -1 by default.
        Dim retVal As Integer = -1

        ' A valid starting index should be specified. if indexOfSearchText = -1, the end of search
        If searchStart >= 0 AndAlso indexOfSearchText >= 0 Then

            ' A valid ending index
            If searchEnd > searchStart OrElse searchEnd = -1 Then

                ' Find the position of search string in RichTextBox
                indexOfSearchText = Rtb.Find(SearchStr, searchStart, searchEnd, RichTextBoxFinds.WholeWord)

                ' Determine whether the text was found in richTextBox1.
                If indexOfSearchText <> -1 Then
                    ' Return the index to the specified search text.
                    retVal = indexOfSearchText
                End If

            End If
        End If
        Return retVal

    End Function

    Public Shared Sub HighlightInternalSyntax(ByRef sender As RichTextBox)

        For Each Word As String In SyntaxTerms
            '  HighlightWord(sender, Word)
            HighlightWord(sender, LCase(Word))
            HighlightWord(sender, ProperCase(Word))
        Next

    End Sub

    Public Shared Sub HighlightWord(ByRef sender As RichTextBox, ByRef word As String)

        Dim index As Integer = 0
        While index < sender.Text.LastIndexOf(word)
            'find
            sender.Find(word, index, sender.TextLength, RichTextBoxFinds.WholeWord)
            'select and color
            sender.SelectionColor = Color.Blue
            ' word = UCase(word)
            index = sender.Text.IndexOf(word, index) + 1
        End While
    End Sub

End Class