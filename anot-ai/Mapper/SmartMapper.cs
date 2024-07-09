using anot_ai.Data.DTO;
using anot_ai.Models;
using Humanizer;

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

        public static SmartDTO ParaDTO(Smart smart)
        {
            return new SmartDTO()
            {
                Specific = smart.Specific,
                Measurable = smart.Measurable,
                Achievable = smart.Achievable,
                Relevant = smart.Relevant,
                Time = smart.Time
            };
        }




    }
}
