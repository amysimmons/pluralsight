//this is a component
var Button = React.createClass({
	localHandleClick: function(){
		this.props.localHandleClick(this.props.increment);
	},
	render: function(){
		return(
			//this.props is the syntax to access properties of the component
			<button onClick={this.localHandleClick}>+{this.props.increment}</button>
		)
	}
});

//this is a component
var Result = React.createClass({
	render: function(){
		return (
			<div>{this.props.localCounter}</div>
		)
	}
});

//creates a main component to render all of the other components
var Main = React.createClass({
	//the state and the handler of the state should stay together
	getInitialState: function(){
		return {counter: 0};
	},
	handleClick: function(increment){
		this.setState({counter: this.state.counter+increment});
	},
	render: function(){
		return(
			<div>
			<Button localHandleClick={this.handleClick} increment={1}/>
			<Button localHandleClick={this.handleClick} increment={5}/>
			<Button localHandleClick={this.handleClick} increment={10}/>
			<Button localHandleClick={this.handleClick} increment={100}/>
			<Result localCounter={this.state.counter}/>
			</div>
		)
	}
});

React.render(<Main />, document.getElementById("root"));







