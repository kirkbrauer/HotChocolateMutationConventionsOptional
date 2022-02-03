using System;
using HotChocolate;
using HotChocolate.Types;

namespace HotChocolateMutationConventionsOptional
{
    public class Mutation
    {
        public Book CreateBookMutationConvention(
            string title,
            Optional<string?> description)
        {
            return new Book
            {
                Id = Guid.NewGuid(),
                Title = title,
                Description = description.HasValue ? description : "No Description"
            };
        }
        
        [UseMutationConvention(Disable = true)]
        public CreateBookPayload CreateBookOld(CreateBookInput input)
        {
            return new CreateBookPayload(new Book
            {
                Id = Guid.NewGuid(),
                Title = input.Title,
                Description = input.Description.HasValue ? input.Description : "No Description"
            });
        }
    }
}