using _9_dars.Models;

namespace _9_dars.Services
{
    public class PostService

    {
        private List<Post> posts;
        public PostService()
        {
            posts = new List<Post>();
            {
                var posts = new List<Post>();
            }
        }
        public Post AddNewPost(Post post)
        {
            post.Id = Guid.NewGuid();
            posts.Add(post);
            return post;
        }

        public Post GetPostById(Guid postId)
        {

            foreach (var post in posts)
            {
                if (post.Id == postId)
                {
                    return post;
                }
            }

            return null;
        }

        public bool DeletePost(Guid postId)
        {
            var postFromDb = GetPostById(postId);
            if (postFromDb is null)
            {
                return false;
            }
            posts.Remove(postFromDb);
            return true;

        }

        public bool UpdatePost(Post updatingpost)
        {
            var postFromDb = GetPostById(updatingpost.Id);
            if (postFromDb is null)
            {
                return false;
            }

            var index = posts.IndexOf(postFromDb);
            posts[index] = updatingpost;
            return true;
        }

        public List<Post> GetAllPosts()
        { 
            return posts; 
        }

        public Post GetMostLikedPost()
        {
            Post mostLikedPost = new Post();
            var mostLikes = 0;
            foreach (var post in posts)
            {
                if (mostLikes < post.QuantityLikes)
                {
                    mostLikes = post.QuantityLikes;
                    mostLikedPost = post;
                }
            }
            return mostLikedPost;


        }

        public Post GetMostViewedPost()
        {
            var responsePost = new Post();
            var maxCounter = 0;

            foreach (var post in posts)
            {
                if (maxCounter < post.ViewerNames.Count)
                {
                    maxCounter = post.ViewerNames.Count;
                    responsePost = post;
                }

            }
            return responsePost;
        }

        public Post GetMostCommentedPost()
        {
            var responsePost = new Post();
            var mostComment = 0;

            foreach(var post in posts)
            {
                if (mostComment < post.Comments.Count)
                {
                    mostComment = post.Comments.Count;
                    responsePost = post;
                }
            }
            return responsePost;

            
        }
         
    }
}