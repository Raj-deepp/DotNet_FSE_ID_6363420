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
}

export default Posts;