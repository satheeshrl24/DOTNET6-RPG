using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNER_RPG.Models;


namespace DOTNER_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
       
        //Task<ServiceResponse<List<Character>>> GetAllCharacters();
        //Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter); 
    }
}