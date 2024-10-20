
using ST_HasH.Object;

namespace ST_HasH.Generator
{
    public partial class SF_HTMLGenerator
    {
        private void _BuildAttributes(ST_HTMLObject P_HTMLObject)
        {
            // Example:
            // SomeAttributeName="SomeValue"
            if (P_HTMLObject.Attributes is not null)
            {
                for (int i = 0; i < P_HTMLObject.Attributes.Count; i++)
                {
                    G_HtmlString
                        .Append(' ')
                        .Append(_Sanitise(P_HTMLObject.Attributes.ElementAt(i).Key))
                        .Append('=')
                        .Append('"')
                        .Append(_Sanitise(P_HTMLObject.Attributes.ElementAt(i).Value.ToString()))
                        .Append('"');
                }
            }
        }
    }

}
