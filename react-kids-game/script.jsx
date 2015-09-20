//sub component
var StarsFrame = React.createClass({
	render: function(){
		//random num between 0 and 9
		var numberOfStars = Math.floor(Math.random()*9)+1;

		var stars = [];
		for(var i=0; i<numberOfStars; i++){
			stars.push(
				<span className="glyphicon glyphicon-star"></span>
			)
		}

		return (
			<div id="stars-frame">
				<div className="well">
					{stars}
				</div>
			</div>
		)
	}
});

//sub component
var ButtonFrame = React.createClass({
	render: function(){
		return (
			<div id="button-frame">
				<button className="btn btn-primary btn-lg">=</button>
			</div>
		)
	}
});

//sub component
var AnswerFrame = React.createClass({
	render: function(){
		return (
			<div id="answer-frame">
				<div className="well">
				...
				</div>
			</div>
		)
	}
});

//sub component
var NumbersFrame = React.createClass({
	render: function(){

		var numbers = [];
		for(i = 1; i <= 9; i ++){
			numbers.push(
				<div className="number">{i}</div>
			)
		}

		return (
			<div id="numbers-frame">
				<div className="well">
					{numbers}
				</div>
			</div>
		)
	}
});

//main component
var Game = React.createClass({
	render: function(){
		return (
			<div id="game">
				<h2>Play Nine</h2>
				<hr />
				<div className="clearfix">
					<StarsFrame />
					<ButtonFrame />
					<AnswerFrame />
				</div>
				<NumbersFrame />
			</div>
		)
	}
});

React.render(
	<Game />,
	document.getElementById('container')
)