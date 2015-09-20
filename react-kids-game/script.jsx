//sub component
var StarsFrame = React.createClass({
	render: function(){
		var stars = [];
		for(var i=0; i<this.props.numberOfStars; i++){
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
		var disabled;
		disabled = (this.props.selectedNumbers.length === 0);
		return (
			<div id="button-frame">
				<button className="btn btn-primary btn-lg" disabled={disabled}>=</button>
			</div>
		)
	}
});

//sub component
var AnswerFrame = React.createClass({
	render: function(){
		var props = this.props;
		var selectedNumbers = props.selectedNumbers.map(function(i){
			return (
				<span onClick={props.unselectNumber.bind(null, i)}>
					{i}
				</span>
			)
		});
		return (
			<div id="answer-frame">
				<div className="well">
					{selectedNumbers}
				</div>
			</div>
		);
	}
});

//sub component
var NumbersFrame = React.createClass({
	render: function(){
		var numbers = [], 
			className, 
			selectedNumbers = this.props.selectedNumbers,
			selectNumber = this.props.selectNumber;
		for(i = 1; i <= 9; i ++){
			//if the number is a selected number, give it a class of selected-true
			className = "number selected-" + (selectedNumbers.indexOf(i)>=0);
			numbers.push(
				//calls the selectNumber method in click and passes in the number
				<div className={className} onClick={selectNumber.bind(null,i)}>{i}</div>
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
	getInitialState: function(){
		return {
			//random num between 0 and 9
			numberOfStars: Math.floor(Math.random()*9)+1,
			selectedNumbers: []
		};
	},
	selectNumber: function(clickedNumber){
		//if the clicked number is not already in the selected numbers, add it
		if(this.state.selectedNumbers.indexOf(clickedNumber) < 0 ){
			this.setState(
				//adds the clicked number to the selected numbers
				{selectedNumbers: this.state.selectedNumbers.concat(clickedNumber)}
			);
		}
	},
	unselectNumber: function(clickedNumber){
		var selectedNumbers = this.state.selectedNumbers,
		indexOfNumber = selectedNumbers.indexOf(clickedNumber);

		//removes the number to unselect from the selected numbers array
		selectedNumbers.splice(indexOfNumber, 1);
		this.setState({selectedNumbers: selectedNumbers});
	},
	//passes the selectedNumbers state into the child component AnswerFrame as a property
	//passes the selectNumber function into the child NumberFrame as a property
	render: function(){
		var selectedNumbers = this.state.selectedNumbers;
		var numberOfStars = this.state.numberOfStars;
		return (
			<div id="game">
				<h2>Play Nine</h2>
				<hr />
				<div className="clearfix">
					<StarsFrame numberOfStars={numberOfStars}/>
					<ButtonFrame selectedNumbers={selectedNumbers}/>
					<AnswerFrame selectedNumbers={selectedNumbers} unselectNumber={this.unselectNumber}/>
				</div>
				<NumbersFrame selectedNumbers={selectedNumbers} selectNumber={this.selectNumber}/>
			</div>
		)
	}
});

React.render(
	<Game />,
	document.getElementById('container')
)