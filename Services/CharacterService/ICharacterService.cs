using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNER_RPG.Dtos.Character;
using DOTNER_RPG.Models;


namespace DOTNER_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
       
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter); 
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}