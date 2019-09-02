using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Quiz.Handler.OptionHandler.Model;

namespace Tpd.Quiz.Handler.OptionHandler.Request
{
    public class GetOptionsQuery : QueryListCore<OptionModel>
    {
        public string Answer { get; set; }
    }
}
