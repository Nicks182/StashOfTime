

namespace SOT_HasH.Object
{
    public partial class HTMLObject
    {
        private List<HTMLObject> _Children { get; set; } = new List<HTMLObject>();
        public List<HTMLObject> Children 
        { 
            get { return _Children; }
        }


        /// <summary>
        /// <para>Add child HTML element.</para>
        /// <para>This is how you nest HTML elements.</para>
        /// </summary>
        public HTMLObject Add_Child(HTMLObject P_Child)
        {
            _Children.Add(P_Child);

            return this;
        }

        /// <summary>
        /// <para>Add many child HTML elements.</para>
        /// <para>This is how you nest HTML elements.</para>
        /// </summary>
        public HTMLObject Add_Children(List<HTMLObject> P_Children)
        {
            _Children.AddRange(P_Children);

            return this;
        }


    }

}
