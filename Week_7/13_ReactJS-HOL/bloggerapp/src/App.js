import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';
import './App.css';

function App(){
  const show = true;

  // Method 1: Element Variable (Book)
  let bookComponent;
  if (show) bookComponent = <BookDetails />;

  // Method 2: Object literal (Blog)
  const blogComponentMap = {
    show: show && <BlogDetails />
  };

  return (
    <div className="app-container">
      <h1>Blogger App</h1>
      <div className="columns">
        {/* Column 1: BookDetails */}
        <div className="column">
          <h2>Book Details</h2>

          <h4>Method 1: Element Variable</h4>
          {bookComponent}

          <h4>Method 2: Object Literal</h4>
          {show && <BookDetails />}

          <h4>Method 3: Ternary</h4>
          {show ? <BookDetails /> : <p>Not available</p>}

          <h4>Method 4: Short-Circuit</h4>
          {show && <BookDetails />}
        </div>

        {/* Column 2: BlogDetails */}
        <div className="column">
          <h2>Blog Details</h2>

          <h4>Method 1: Element Variable</h4>
          {(() => {
            let blogVar;
            if (show) blogVar = <BlogDetails />;
            return blogVar;
          })()}

          <h4>Method 2: Object Literal</h4>
          {blogComponentMap.show}

          <h4>Method 3: Ternary</h4>
          {show ? <BlogDetails /> : <p>Not available</p>}

          <h4>Method 4: Short-Circuit</h4>
          {show && <BlogDetails />}
        </div>

        {/* Column 3: CourseDetails */}
        <div className="column">
          <h2>Course Details</h2>

          <h4>Method 1: Element Variable</h4>
          {(() => {
            let courseVar;
            if (show) courseVar = <CourseDetails />;
            return courseVar;
          })()}

          <h4>Method 2: Object Literal</h4>
          {show && <CourseDetails />}

          <h4>Method 3: Ternary</h4>
          {show ? <CourseDetails /> : <p>Not available</p>}

          <h4>Method 4: Short-Circuit</h4>
          {show && <CourseDetails />}
        </div>
      </div>
    </div>
  );
}

export default App;