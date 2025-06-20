using Course.Global.DataOperations;
using Course.Global.Objects;
using Course.Render.Controls;
using System.Collections;

namespace Course.Render.Forms;

public partial class FormFullList : Form
{
    private DataFacade _facade;

    public FormFullList(DataFacade facade)
    {
        _facade = facade;

        InitializeComponent();
    }

    public void ShowFullList(IEnumerable objects, Type type)
    {
        if (!objects.Cast<Object>().Any())
            return;

        flowLayoutElements.Controls.Clear();

        foreach (IObject obj in objects)
        {
            ObjectControl objectControl = new ObjectControl(_facade);
            
            objectControl.ObjectData = obj;

            flowLayoutElements.Controls.Add(objectControl);
        }
    }
}
