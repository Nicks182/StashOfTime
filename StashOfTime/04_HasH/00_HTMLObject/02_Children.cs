

namespace ST_HasH.Object
{
    public partial class ST_HTMLObject
    {
        private List<ST_HTMLObject> _Children { get; set; } = new List<ST_HTMLObject>();
        public List<ST_HTMLObject> Children 
        { 
            get { return _Children; }
        }


        /// <summary>
        /// <para>Add child HTML element.</para>
        /// <para>This is how you nest HTML elements.</para>
        /// </summary>
        public ST_HTMLObject Add_Child(ST_HTMLObject P_Child)
        {
            if (P_Child is not null)
            {
                _Children.Add(P_Child);
            }

            return this;
        }

        /// <summary>
        /// <para>Add many child HTML elements.</para>
        /// <para>This is how you nest HTML elements.</para>
        /// </summary>
        public ST_HTMLObject Add_Children(List<ST_HTMLObject> P_Children)
        {
            _Children.AddRange(P_Children);

            return this;
        }


    }

}
