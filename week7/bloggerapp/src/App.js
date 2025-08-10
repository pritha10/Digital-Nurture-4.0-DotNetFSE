import React, { useState } from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [selected, setSelected] = useState('book');

  // Option 1: Element Variable
  let detailComponent;
  if (selected === 'book') detailComponent = <BookDetails />;
  else if (selected === 'blog') detailComponent = <BlogDetails />;
  else detailComponent = <CourseDetails />;

  // Option 2: Ternary Operator
  const isBlog = selected === 'blog';

  // Option 3: && Operator (only if course selected)
  const showCourse = selected === 'course';

  return (
    <div style={{ textAlign: 'center', padding: '20px' }}>
      <h1>📖 Blogger App</h1>
      <button onClick={() => setSelected('book')}>Book</button>
      <button onClick={() => setSelected('blog')}>Blog</button>
      <button onClick={() => setSelected('course')}>Course</button>

      <hr />

      <h3>🔹 Conditional Rendering - Element Variable</h3>
      {detailComponent}

      <h3>🔹 Ternary Operator</h3>
      {isBlog ? <BlogDetails /> : <p>Blog not selected</p>}

      <h3>🔹 Logical && Operator</h3>
      {showCourse && <CourseDetails />}
    </div>
  );
}

export default App;
