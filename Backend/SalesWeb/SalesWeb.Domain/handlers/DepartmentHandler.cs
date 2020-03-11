using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWeb.Domain.handlers
{
    public class DepartmentHandler
    {
        private Dictionary<string, string> _validations;
        private bool Valid { get; }
        private bool Invalid { get; }

        public DepartmentHandler()
        {
            _validations = new Dictionary<string, string>();
        }

        public async Task AddDepartment()
        {

        }
    }
}