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
        public static Smart ParaEntidade(SmartSimples dto)
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
            if (smart == null)
            {
                return null;
            }
            return new SmartDTO()
            {
                Id = smart.Id,
                Specific = smart.Specific,
                Measurable = smart.Measurable,
                Achievable = smart.Achievable,
                Relevant = smart.Relevant,
                Time = smart.Time
            };
        }




    }
}
