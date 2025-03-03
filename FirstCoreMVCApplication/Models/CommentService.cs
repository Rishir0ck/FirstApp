using System;

namespace FirstCoreMVCApplication.Models;

public class CommentService
{
    public static async Task<List<Comment>> GetCommentsAsync()
    {
        await Task.Delay(500);
        return new List<Comment>
        {
            new Comment { Text = "First comment", User = "Alice" },
            new Comment { Text = "Second comment", User = "Bob" },
            new Comment { Text = "Third comment", User = "Charlie" }
        };

         
    }




}
