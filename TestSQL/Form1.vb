Public Class Form1

    Public Enum lDate
        d0 = 7
        d1 = 8
        d2 = 9
        d3 = 10
        d4 = 11
        d5 = 12
        d6 = 13
        d7 = 14
        d8 = 15
        d9 = 16
        d10 = 17
        d11 = 18
        d12 = 19
        d13 = 20
        d14 = 21
        d15 = 22
        d16 = 23
        d17 = 24
        d18 = 25
        d19 = 26
        d20 = 27
        d21 = 28
        d22 = 29
        d23 = 30
        d24 = 31
        d25 = 32
        d26 = 33
        d27 = 34
        d28 = 35
        d29 = 36
        d30 = 37
        d31 = 38
        d32 = 39
        d33 = 40
        d34 = 41
        d35 = 42
        d36 = 43
        d37 = 44
        d38 = 45
        d39 = 46
        d40 = 47
        d41 = 48
        d42 = 49
        d43 = 50
        d44 = 51
        d45 = 52
        d46 = 53
        d47 = 54
        d48 = 55
        d49 = 56
        d50 = 57
        d51 = 58
        d52 = 59
        d53 = 60
        d54 = 61
        d55 = 62
        d56 = 63
        d57 = 64
        d58 = 65
        d59 = 66
    End Enum

    Public Enum lQty
        q0 = 67
        q1 = 68
        q2 = 69
        q3 = 70
        q4 = 71
        q5 = 72
        q6 = 73
        q7 = 74
        q8 = 75
        q9 = 76
        q10 = 77
        q11 = 78
        q12 = 79
        q13 = 80
        q14 = 81
        q15 = 82
        q16 = 83
        q17 = 84
        q18 = 85
        q19 = 86
        q20 = 87
        q21 = 88
        q22 = 89
        q23 = 90
        q24 = 91
        q25 = 92
        q26 = 93
        q27 = 94
        q28 = 95
        q29 = 96
        q30 = 97
        q31 = 98
        q32 = 99
        q33 = 100
        q34 = 101
        q35 = 102
        q36 = 103
        q37 = 104
        q38 = 105
        q39 = 106
        q40 = 107
        q41 = 108
        q42 = 109
        q43 = 110
        q44 = 111
        q45 = 112
        q46 = 113
        q47 = 114
        q48 = 115
        q49 = 116
        q50 = 117
        q51 = 118
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTables()
    End Sub

    Private Sub loadTables()
        Try
            Me.TaMovement.Fill(Me.DsLowes.dtMovement)
            Me.TaItem.Fill(Me.DsLowes.dtItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub readFile(strFileName As String)
        Dim iTest As Integer = 0
        Dim dTest As Double = 0.0
        Dim bReturn As Boolean = True
        Try
            Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser(strFileName)
                Reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.FixedWidth
                Reader.SetFieldWidths(7, 6, 2, 25, 13, 7, 9, _
                                        8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, _
                                        5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5)

                Dim currentRow As String()
                Dim i As Integer = 1
                While Not Reader.EndOfData
                    Try
                        lblProgress.Text = "Line: " & i.ToString.Trim
                        Application.DoEvents()
                        currentRow = Reader.ReadFields()
                        If Not addItem(currentRow, i) Then
                            bReturn = False
                            Exit While
                        End If
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & i & ": " & "is not valid and will be skipped. " & ex.Message)
                    Catch ex As Exception
                        MsgBox("Line " & i & ": " & "is not valid and will be skipped. " & ex.Message)
                    End Try
                    i = i + 1
                End While

                If bReturn Then
                    MessageBox.Show("Items imported successfully.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function addItem(currentRow As String(), iCurLine As Integer) As Boolean
        Dim bReturn As Boolean = True
        Dim iTest As Integer = 0
        Dim dTest As Double = 0.0
        Try
            bsItem.AddNew()

            If Integer.TryParse(currentRow(0), iTest) Then
                bsItem.Current("itemNo") = currentRow(0)
            Else
                Throw New Exception("Item No: " & currentRow(0) & " is not a valid integer.")
            End If

            bsItem.Current("size") = currentRow(1).Trim()

            bsItem.Current("UoM") = currentRow(2).Trim()

            bsItem.Current("desc") = currentRow(3).Trim()

            bsItem.Current("UPC") = currentRow(4).Trim()

            bsItem.EndEdit()
            TaItem.Update(DsLowes.dtItem)
        Catch ex As Exception
            bReturn = False
            MessageBox.Show("Line " & iCurLine & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return bReturn
    End Function

    Private Sub DtItemBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.bsItem.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsLowes)

    End Sub

    Private Sub ReadTextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadTextFileToolStripMenuItem.Click
        readFile(CurDir() & "\datafiles\AUDITMVMT_CURR.TXT")
    End Sub

    Private Sub ClearItemTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearItemTablesToolStripMenuItem.Click
        Try
            If MessageBox.Show("Are you sure you want to delete all the Item data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                TaMovement.DeleteAll()
                TaItem.DeleteAll()
                loadTables()
                MessageBox.Show("Item data cleared.", "Cleard", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
