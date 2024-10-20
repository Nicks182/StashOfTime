
namespace ST_StateManager.Object
{
    public partial class ST_StateObject
    {
        private Dictionary<int, ST_StateObject_Row> _Rows { get; set; } = new Dictionary<int, ST_StateObject_Row>();
        public Dictionary<int, ST_StateObject_Row> Rows 
        { 
            get { return _Rows; }
        }

        public ST_StateObject _Add_Row(ST_StateObject_Row P_Row)
        {
            _Rows.Add(P_Row.Index, P_Row);
            return this;
        }

        public ST_StateObject _Clear_Rows()
        {
            _Rows.Clear();
            return this;
        }
    }

    public class ST_StateObject_Row
    {
        public int Index { get; set; } = 0;
        Dictionary<Guid, ST_StateObject_Cell> Cells { get; set; } = new Dictionary<Guid, ST_StateObject_Cell>();

        public ST_StateObject_Row _Add_Cell(Guid P_ColumnId, ST_StateObject_Cell P_Cell)
        {
            Cells.Add(P_ColumnId, P_Cell);
            return this;
        }

        public ST_StateObject_Cell _Get_Cell(Guid P_ColumnId)
        {
            return Cells[P_ColumnId];
        }
    }
}
