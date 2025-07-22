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
}

export default Posts;