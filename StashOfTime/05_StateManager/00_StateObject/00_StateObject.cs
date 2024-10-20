

namespace ST_StateManager.Object
{
    public partial class ST_StateObject
    {
        public ST_StateObject()
        {
            _StateId = Guid.NewGuid();
        }

        private Guid _StateId { get; set; }
        public Guid StateId
        {
            get { return _StateId; }
        }


        public string Caption { get; set; } = string.Empty;
    }
}
