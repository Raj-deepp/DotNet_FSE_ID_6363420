import React from "react";
import Post from "./Post";

class Posts extends React.Component{
  constructor(props){
    super(props);
    this.state= {
      posts: [],
      hasError: false
    };
  }

  componentDidMount(){
    this.loadPosts();
  }

  loadPosts(){
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then((res)=> res.json())
      .then((data)=> this.setState({posts: data}))
      .catch((error)=> {
        console.error("Error fetching posts:", error);
        this.setState({hasError: true});
      });
  }

  componentDidCatch(error, info){
    alert("An error occurred while rendering the component.");
    console.error("Error caught:", error, info);
  }

  render(){
    if (this.state.hasError){
      return <p>Error occurred while fetching posts.</p>;
    }

    return(
      <div>
        <h2>Posts</h2>
        {this.state.posts.map((post)=> (
          <Post key={post.id} title={post.title} body={post.body} />
        ))}
      </div>
    );
  }
}

export default Posts;