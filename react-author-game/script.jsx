var Quiz = React.createClass({
	propTypes: {
		data: React.PropTypes.array.isRequired
	},
	getInitialState: function(){
		return _.extend({
			bgClass: 'neutral',
			showContinue: false
		}, this.props.data.selectGame());
	},
	//when a user selects an answer, it will bubble the selected book up to this component 
	handleBookSelected: function(title){
		var isCorrect = this.state.checkAnswer(title);
		this.setState({
			bgClass: isCorrect ? 'pass' : 'fail',
			showContinue: isCorrect
		});
	},
	handleContinue: function(){
		this.setState(this.getInitialState());
	},
	render: function() {
		return (<div>
			<div className="row">
				<div className="col-md-4">
					<img src={this.state.author.imageUrl} className="authorimage col-md-3"/>
				</div>
				<div className="col-md-7">
					{this.state.books.map(function(b){
						return <Book onBookSelected={this.handleBookSelected} title={b}/>;
					}, this)}
				</div>
				<div className={"col-md-1 " + this.state.bgClass}></div>
			</div>
			{this.state.showContinue ? (
			<div className="row">
				<div className="col-md-12">
					<input onClick={this.handleContinue} type="button" className="btn btn-primary" value="Continue"/>
				</div>
			</div>) : <span/>
			}
			</div>
		);
	}
});

var Book = React.createClass({
	propTypes: {
		title: React.PropTypes.string.isRequired
	},
	handleClick: function(){
		//the book component now publishes an onBookSelected event
		//the next step is to get the parent component to publish the callback 
		this.props.onBookSelected(this.props.title);
	},
	render: function(){
		return (
		<div onClick={this.handleClick} className="answer">
			<h4>{this.props.title}</h4>
		</div>);
	}
});

var data = [
	{
		name: 'Stephanie Meyer',
		imageUrl: 'images/meyer.jpeg',
		books: ['Twilight', 'New Moon', 'Eclipse', 'Breaking Dawn']
	},
	{
		name: 'Suzanne Collins',
		imageUrl: 'images/collins.jpeg',
		books: ['The Hunger Games', 'Catching Fire', 'Mockingjay']
	},
	{
		name: 'Veronica Roth',
		imageUrl: 'images/divergent.jpeg',
		books: ['Divergent', 'Insurgent', ]
	},
	{
		name: 'E. L. James',
		imageUrl: 'images/shades.jpeg',
		books: ['50 Shades of Grey', '50 Shades Darker', 'Fifty Shades Freed']
	}
];

data.selectGame = function(){
	var books = _.shuffle(this.reduce(function(p,c,i){
		return p.concat(c.books);
	}, [])).slice(0,4);

	var answer = books[_.random(books.length-1)];

	return {
		books: books,
		author: _.find(this, function(author){
			return author.books.some(function(title){
				return title === answer;
			});
		}),

		checkAnswer: function(title){
			return this.author.books.some(function(t){
				return t === title;
			});
		}
	}
};

React.render(
	//gives the quiz a data attribute 
	//binds it to an element on the dom
	//this attribute can then be accessed within the Quiz component
	//via this.props.data 
	<Quiz data={data}/>,
	document.getElementById('app')
)
