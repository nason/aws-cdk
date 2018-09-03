import { IInternalState } from "./asl-internal-api";

export interface IChainable {
    toStateChain(): IStateChain;
}

export interface IStateChain extends IChainable {
    readonly startState: IInternalState;

    then(state: IChainable): IStateChain;
    catch(targetState: IChainable, ...errors: string[]): IStateChain;
}

// tslint:disable-next-line:no-empty-interface
export interface IState extends IChainable {
}

/**
 * Predefined error strings
 */
export class Errors {
    /**
     * Matches any Error.
     */
    public static all = 'States.ALL';

    /**
     * A Task State either ran longer than the “TimeoutSeconds” value, or
     * failed to heartbeat for a time longer than the “HeartbeatSeconds” value.
     */
    public static timeout = 'States.Timeout';

    /**
     * A Task State failed during the execution.
     */
    public static taskFailed = 'States.TaskFailed';

    /**
     * A Task State failed because it had insufficient privileges to execute
     * the specified code.
     */
    public static permissions = 'States.Permissions';

    /**
     * A Task State’s “ResultPath” field cannot be applied to the input the state received.
     */
    public static resultPathMatchFailure = 'States.ResultPathMatchFailure';

    /**
     * A branch of a Parallel state failed.
     */
    public static branchFailed = 'States.BranchFailed';

    /**
     * A Choice state failed to find a match for the condition field extracted
     * from its input.
     */
    public static noChoiceMatched = 'States.NoChoiceMatched';
}

export interface RetryProps {
    errors?: string[];

    /**
     * @default 1
     */
    intervalSeconds?: number;

    /**
     * May be 0 to disable retry in case of multiple entries.
     *
     * @default 3
     */
    maxAttempts?: number;

    /**
     * @default 2
     */
    backoffRate?: number;
}