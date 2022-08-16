import escape from 'escape-html';

const html = escape('foo & bar');
console.info(html);
// -> foo &amp; bar