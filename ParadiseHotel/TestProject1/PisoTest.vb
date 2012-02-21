Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Dominio



'''<summary>
'''This is a test class for PisoTest and is intended
'''to contain all PisoTest Unit Tests
'''</summary>
<TestClass()> _
Public Class PisoTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for Numero
    '''</summary>
    <TestMethod()> _
    Public Sub NumeroTest()
        Dim target As Piso = New Piso(1, 30) ' TODO: Initialize to an appropriate value
        Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Short
        target.Numero = expected
        actual = target.Numero
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Metraje
    '''</summary>
    <TestMethod()> _
    Public Sub MetrajeTest()
        Dim target As Piso = New Piso(1, 30) ' TODO: Initialize to an appropriate value
        Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Short
        target.Metraje = expected
        actual = target.Metraje
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for DevolverCol
    '''</summary>
    <TestMethod()> _
    Public Sub DevolverColTest()
        Dim target As Piso = New Piso(1, 30) ' TODO: Initialize to an appropriate value
        Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Object
        actual = target.DevolverHabitaciones
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for AgregarHabitacion
    '''</summary>
    <TestMethod()> _
    Public Sub AgregarHabitacionTest()
        Dim target As Piso = New Piso(1, 30) ' TODO: Initialize to an appropriate value
        Dim objHab As Habitacion = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Object
        actual = target.AgregarHabitacion(objHab)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Piso Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub PisoConstructorTest()
        Dim target As Piso = New Piso(1, 30)
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
