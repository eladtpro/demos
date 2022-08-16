const start = Date.now();

const pattern = '^((ab)*)+$';
// const pattern = '/A(B|C+)+D/'
const regex = new RegExp(pattern);

const easy = 'abababababababababababababababababababababababab';
const wtf = 'abababababababababababab a';
// const easy = 'ACCCCCD';
// const reasonable = 'ACCCCCCCCCCCCCCCCCCCCCCCCCCCCD'; //30 characters long
// const wtf = 'ACCCCCCCCCCCCCCCCCCCCCCCCCCCCX'; //30 characters long

const logRegexTime = (testee) => {
    regex.test(testee);
    console.log(`Test ${testee}: ${Date.now() - start}`);
}

logRegexTime(easy);
// logRegexTime(reasonable)
logRegexTime(wtf)
