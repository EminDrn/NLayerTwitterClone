using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Tweet> _service;

        public TweetsController(IService<Tweet> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var tweets = await _service.GetAllAsync();
            var tweetDtos = _mapper.Map<List<TweetDto>>(tweets.ToList());
            return CreateActionResult(CustomResponseDto<List<TweetDto>>.Succes(200, tweetDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tweet = await _service.GetByIdAsync(id);
            var tweetDtos = _mapper.Map<TweetDto>(tweet);
            return CreateActionResult(CustomResponseDto<TweetDto>.Succes(200, tweetDtos));
        }


        [HttpPost]
        public async Task<IActionResult> Save(TweetDto tweetDto)
        {
            var tweet = await _service.AddAsync(_mapper.Map<Tweet>(tweetDto));
            var tweetDtos = _mapper.Map<TweetDto>(tweet);
            return CreateActionResult(CustomResponseDto<TweetDto>.Succes(200, tweetDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TweetDto tweetDto)
        {
            await _service.UpdateAsync(_mapper.Map<Tweet>(tweetDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var tweet = await _service.GetByIdAsync(id);
            if (tweet == null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "bu id ye sahip tweet bulunamadı"));

            }
            await _service.RemoveAsync(tweet);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

    }
}
