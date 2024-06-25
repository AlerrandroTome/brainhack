using AutoMapper;
using BrainHack.Application.InputModel.Card;
using BrainHack.Application.InputModel.Deck;
using BrainHack.Application.ViewModel.Card;
using BrainHack.Application.ViewModel.Deck;
using BrainHack.Core.Entities;

namespace BrainHack.Core.Mapping
{
    public class DeckProfile : Profile
    {
        public DeckProfile()
        {
            CreateMap<CreateDeckInputModel, Deck>().ReverseMap();
            CreateMap<CreateCardInputModel, Card>().ReverseMap();

            CreateMap<UpdateDeckInputModel, Deck>().ReverseMap();
            CreateMap<UpdateCardInputModel, Card>().ReverseMap();

            CreateMap<DeckViewModel, Deck>().ReverseMap();
            CreateMap<CardViewModel, Card>().ReverseMap();
        }
    }
}
