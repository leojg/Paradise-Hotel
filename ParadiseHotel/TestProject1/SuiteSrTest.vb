Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Dominio



'''<summary>
'''This is a test class for SuiteSrTest and is intended
'''to contain all SuiteSrTest Unit Tests
'''</summary>
<TestClass()> _
Public Class SuiteSrTest


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
    '''A test for Nombre
    '''</summary>
    <TestMethod()> _
    Public Sub NombreTest()
        Dim nom As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim id As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim numpiso As Short = 0 ' TODO: Initialize to an appropriate value
        Dim costo As Short = 0 ' TODO: Initialize to an appropriate value
        Dim target As SuiteSr = New SuiteSr(nom, id, numpiso, costo) ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        target.Nombre = expected
        actual = target.Nombre
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for SuiteSr Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub SuiteSrConstructorTest()
        Dim nom As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim id As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim numpiso As Short = 0 ' TODO: Initialize to an appropriate value
        Dim costo As Short = 0 ' TODO: Initialize to an appropriate value
        Dim target As SuiteSr = New SuiteSr(nom, id, numpiso, costo)
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
