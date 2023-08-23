Public Class frmHome

    'RECOMMENDED VARIABLES TO Use, reference Homework #5
    'I would probably use all these variables if I were doing the project.

    Dim db As New bit3444_projectdata

    'Think about how many assignment options there should be and make sure you loops 
    'correspond to the right number of anticipated options
    Dim assignmentOptions As New List(Of Assignment)

    Dim stafflist As List(Of tblStaff)

    Dim staffnameList As New SortedList(Of Integer, String)
    '^^^^^ HINT ^^^^^^^^: 
    'Add the StaffID and the Display Name in the SortedList
    'Use this list To populate the list box. Then Using a LINQ statement
    'You can get the staffid from the key value to get the Selected Staff 

    Dim projectlist As List(Of tblProject)

    Dim weeks() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}



    'Requirement 1: On Form Load Populate the variables ABOVE ^^^^^^^
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Requirement 2: Add a button and check box on the Form and program the OnClick

    'Requirement 3: Add a Tab Control and various other components

    'REMEMBER TO USE LINQ Statements. These statements will get you all the values you need
    'Assignments







End Class