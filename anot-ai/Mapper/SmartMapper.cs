using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Mapper
{
    public class SmartMapper
    {

        public static Smart ParaEntidade(SmartDTO dto)
        {
            return new Smart()
            {
                Specific = dto.Specific,
                Measurable = dto.Measurable,
                Achievable = dto.Achievable,
                Relevant = dto.Relevant,
                Time = dto.Time
            };
        }




    }
}
