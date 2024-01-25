[TestCase(1)]
public class TC_001 : TestCase
{
    [TestStep(1)]
    public void Step1(ITester t)
    {
        App.Auswahl.Von.EnterWithoutVerification($@"Uster");
        App.Auswahl.Nach.EnterWithoutVerification($@"Zürich");
        App.Auswahl.Züge.Click(App.Kauf.WaitForAppear);
    }


    [TestStep(2)]
    public void Step2(ITester t)
    {
        App.Kauf.Tickets1.SetSearchArea<Progile.TRIO.BaseModel.Button>(App.Kauf.Zug1Abfahrt).Click(App.Final.WaitForAppear);
        t.Report.PassFailStep(App.Final.Zug1Label.WaitForAppear(), $@"The element {/*element*/ App.Final.Zug1Label} was displayed on the screen.", $@"The element {/*element*/ App.Final.Zug1Label} was not found on the screen.");
        App.Final.Zurück.Click(App.Auswahl.WaitForAppear);
        App.Auswahl.Züge.Click(App.Kauf.WaitForAppear);
    }


    [TestStep(3)]
    public void Step3(ITester t)
    {
        App.Kauf.Tickets2.SetSearchArea<Progile.TRIO.BaseModel.Button>(App.Kauf.Zug2Abfahrt).Click(App.Final.WaitForAppear);
        t.Report.PassFailStep(App.Final.Zug2Label.WaitForAppear(), $@"The element {/*element*/ App.Final.Zug2Label} was displayed on the screen.", $@"The element {/*element*/ App.Final.Zug2Label} was not found on the screen.");
        App.Final.Zurück.Click(App.Auswahl.WaitForAppear);
        App.Auswahl.Züge.Click(App.Kauf.WaitForAppear);
    }


    [TestStep(4)]
    public void Step4(ITester t)
    {
        App.Kauf.Tickets3.SetSearchArea<Progile.TRIO.BaseModel.Button>(App.Kauf.Zug3Abfahrt).Click(App.Final.WaitForAppear);
        t.Report.PassFailStep(App.Final.Zug3Label.WaitForAppear(), $@"The element {/*element*/ App.Final.Zug3Label} was displayed on the screen.", $@"The element {/*element*/ App.Final.Zug3Label} was not found on the screen.");
        App.Final.Zurück.Click(App.Auswahl.WaitForAppear);
    }



}
