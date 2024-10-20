
using ST_HasH.Object;

namespace ST_HasH.Generator
{
    public partial class SF_HTMLGenerator
    {
        private void _BuildElement(ST_HTMLObject P_HTMLObject)
        {
            
            _BuildElement_Open(P_HTMLObject);

            if (P_HTMLObject.HasInnerText() == true)
            {
                _BuildElement_Text(P_HTMLObject);
            }

            if (P_HTMLObject.Children is not null)
            {
                for (int i = 0; i < P_HTMLObject.Children.Count; i++)
                {
                    _BuildElement(P_HTMLObject.Children[i]);
                }
            }

            _BuildElement_Close(P_HTMLObject);
        }

        private void _BuildElement_Open(ST_HTMLObject P_HTMLObject)
        {
            G_HtmlString
                .Append('<')
                .Append(P_HTMLObject.Type);
            
            _BuildAttributes(P_HTMLObject);
            G_HtmlString.Append('>');
        }

        private void _BuildElement_Close(ST_HTMLObject P_HTMLObject)
        {
            G_HtmlString.Append("</")
                .Append(P_HTMLObject.Type);
            
            G_HtmlString.Append('>');
        }


        private void _BuildElement_Text(ST_HTMLObject P_HTMLObject)
        {
            if (P_HTMLObject.IsRaw == true)
            {
                G_HtmlString.Append(P_HTMLObject.InnerText);
            }
            else
            {
                G_HtmlString.Append(_Sanitise(P_HTMLObject.InnerText));
            }
        }
    }
}
