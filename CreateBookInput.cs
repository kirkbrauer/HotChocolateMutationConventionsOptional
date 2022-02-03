using HotChocolate;

namespace HotChocolateMutationConventionsOptional
{
    public record CreateBookInput(string Title, Optional<string?> Description);
}