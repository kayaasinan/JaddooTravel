﻿using JaddooTravel.Dtos.TestimonialDtos;
using JaddooTravel.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IActionResult> TestimonialList()
        {
            var values = await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            await _testimonialService.CreateTestimonialAsync(createTestimonialDto);
            return RedirectToAction("TestimonialList");
        }

        public async Task<IActionResult> DeleteTestimonial(string id)
        {
            await _testimonialService.DeleteTestimonialAsync(id);
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(string id)
        {
            var values = await _testimonialService.GetTestimonialByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            await _testimonialService.UpdateTestimonialAsync(updateTestimonialDto);
            return RedirectToAction("TestimonialList");
        }
    }
}